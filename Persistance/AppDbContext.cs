using dotnetT.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetT.Persistance
{ 
     public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}