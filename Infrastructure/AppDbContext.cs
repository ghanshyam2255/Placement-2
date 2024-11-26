using Infrastructure.Data.Model.Department;
using Infrastructure.Data.Model.Employee;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }

        public DbSet<Department> Department { get; set; }

        //public DbSet<department> Department { get; set; }
    }
}
