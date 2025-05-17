using Microsoft.AspNetCore.Mvc;
using SoliAntique.Helpers;
using SoliAntique.Models;

namespace SoliAntique.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            return View(cart);
        }
    }
}
