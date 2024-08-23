using Microsoft.EntityFrameworkCore;
using System;
using OfficeGym.Models;

namespace OfficeGym.Data
{
    public class MvcOfficeGymDbContext : DbContext
    {
        public MvcOfficeGymDbContext(DbContextOptions<MvcOfficeGymDbContext> options) : base(options)
        {

        }

        public DbSet<OfficeEquipmentGym> OfficeEquipmentsGym { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeOfficeEquipmentGym> EmployeesOfficeEquipmentsGym { get; set; }
        public DbSet<EmployeeSales> EmployeesSales { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
    }
}
