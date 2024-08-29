using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeGym.Data;
using OfficeGym.Models;

namespace OfficeGym.Controllers
{
    public class OfficeEquipmentsGymController : Controller
    {
        private readonly MvcOfficeGymDbContext context;

        public OfficeEquipmentsGymController(MvcOfficeGymDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<OfficeEquipmentGym> officeEquipmentsGym = await context.OfficeEquipmentsGym.ToListAsync();
            return View(officeEquipmentsGym);
        }
    }
}
