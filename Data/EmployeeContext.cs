using MyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Data 
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) 
        {

        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}