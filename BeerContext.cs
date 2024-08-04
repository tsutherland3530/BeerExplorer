using Microsoft.EntityFrameworkCore;
using BeerExplorer.Models;

namespace BeerExplorer.Data
{
    public class BeerContext : DbContext
    {
        public BeerContext(DbContextOptions<BeerContext> options) : base(options) { }

        public DbSet<BeerStyle> BeerStyles { get; set; }
        public DbSet<FoodPairing> FoodPairings { get; set; }
    }
}
