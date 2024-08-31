using Microsoft.EntityFrameworkCore;
using Task_Auth.Models;

namespace Task_Auth.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
