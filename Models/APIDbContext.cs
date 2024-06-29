using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions option):base(option)
        {

        }
        public DbSet<student> students { get; set; }
        public DbSet<Employee> employee { get; set; }
    }
}
