using Microsoft.AspNetCore.Mvc;

namespace SoliAntique.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
