using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models; // Đảm bảo đúng namespace

namespace FirstWebMVC.Data // Đúng namespace của dự án
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
