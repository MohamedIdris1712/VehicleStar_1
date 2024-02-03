using Microsoft.EntityFrameworkCore;
using VehicleStar.Models;

namespace VehicleStar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Brand> Brand { get; set; }
    }
}
