using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeGym.Data;

namespace OfficeGym.Controllers
{
    public class EmployeesSalesController : Controller
    {
        private readonly MvcOfficeGymDbContext context;

        public EmployeesSalesController(MvcOfficeGymDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            var empSales = await context.EmployeesSales
                .Include(e => e.Employee)
                .ToListAsync();

            return View(empSales);
        }
    }
}
