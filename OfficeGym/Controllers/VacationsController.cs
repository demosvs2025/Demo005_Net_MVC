using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeGym.Data;
using OfficeGym.Models;

namespace OfficeGym.Controllers
{
    public class VacationsController : Controller
    {
        private readonly MvcOfficeGymDbContext context;

        public VacationsController(MvcOfficeGymDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Vacation> vacations = await context.Vacations
                .Include(e => e.Employee)
                .ToListAsync();
            return View(vacations);
        }
    }
}
