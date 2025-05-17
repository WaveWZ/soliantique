using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoliAntique.Data;
using SoliAntique.Models;

namespace SoliAntique.Controllers
{
    public class IranianController : Controller
    {
        private readonly AppDbContext _context;

        public IranianController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var carpets = await _context.IranianCarpets
                .Include(c => c.Images)
                .ToListAsync();
            return View(carpets);
        }
        public async Task<IActionResult> Details(int id)
        {
            var carpet = await _context.IranianCarpets
                .Include(c => c.Images)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (carpet == null)
                return NotFound();

            return View(carpet);
        }
    }
}
