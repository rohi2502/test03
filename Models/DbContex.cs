using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class DbContex
    {
        private DbContextOptions option;

        public DbContex(DbContextOptions option)
        {
            this.option = option;
        }
    }
}