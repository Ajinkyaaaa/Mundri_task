using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mundri_task.Models;

namespace Mundri_task.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

         public DbSet<Employee> Employees { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData
               (
                 new Employee { Id = 1, Name = "John Doe", Department = "Engineering", Salary = 60000 },
                new Employee { Id = 2, Name = "Jane Smith", Department = "Marketing", Salary = 55000 },
                new Employee { Id = 4, Name = "Bob Brown", Department = "Human Resources", Salary = 50000 },
                new Employee { Id = 5, Name = "Charlie Davis", Department = "Sales", Salary = 70000 }


               );
        }
    }
}
