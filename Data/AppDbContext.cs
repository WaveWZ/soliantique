using Microsoft.EntityFrameworkCore;
using SoliAntique.Models;

namespace SoliAntique.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<VintageCarpet> VintageCarpets { get; set; }
        public DbSet<TurkishCarpet> TurkishCarpets { get; set; }
        public DbSet<IranianCarpet> IranianCarpets { get; set; }
        public DbSet<CarpetImage> CarpetImages { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
