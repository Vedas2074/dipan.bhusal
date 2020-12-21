using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Models;

namespace EmployeeManagement.Data

{
    public class EMSContext:DbContext
    {
        public EMSContext(DbContextOptions<EMSContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees {get; set;}
    }
}