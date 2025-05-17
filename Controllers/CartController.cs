using Microsoft.AspNetCore.Mvc;
using SoliAntique.Data;
using SoliAntique.Models;
using SoliAntique.Helpers;

namespace SoliAntique.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            return View(cart);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, string title, decimal price, string imageUrl, string productType)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();

            var existingItem = cart.FirstOrDefault(i => i.ProductId == productId && i.ProductType == productType);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cart.Add(new CartItem
                {
                    ProductId = productId,
                    Title = title,
                    Price = price,
                    ImageUrl = imageUrl,
                    ProductType = productType,
                    Quantity = 1
                });
            }

            HttpContext.Session.SetObjectAsJson("Cart", cart);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int productId, string productType)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            var itemToRemove = cart.FirstOrDefault(i => i.ProductId == productId && i.ProductType == productType);

            if (itemToRemove != null)
            {
                cart.Remove(itemToRemove);
            }

            HttpContext.Session.SetObjectAsJson("Cart", cart);
            return RedirectToAction("Index");
        }
    }
}
