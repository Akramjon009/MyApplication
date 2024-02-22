using Microsoft.EntityFrameworkCore;
using MyApplication.Domain.Entities.Models;

namespace MyApplication.Infrastruct.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}
