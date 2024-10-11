using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class SurvivorDbContext : DbContext
    {
        public SurvivorDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
