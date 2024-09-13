using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OfficeGym.Data;
using OfficeGym.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace OfficeGym.Controllers
{
    public class EmployeesOfficeEquipmentsGymController : Controller
    {
        private readonly MvcOfficeGymDbContext context;

        public EmployeesOfficeEquipmentsGymController(MvcOfficeGymDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            var empOffEq = await context.EmployeesOfficeEquipmentsGym
                .Include(e => e.Employee)
                .Include(o => o.OfficeEquipmentGym)
                .ToListAsync();

            return View(empOffEq);
        }


    }
}
