using EmployeeWebApp.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebApp.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
