using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OfficeEquipmentGym officeEquipmentGym)
        {
            if (ModelState.IsValid) 
            {
                context.Add(officeEquipmentGym);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(officeEquipmentGym);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id) 
        {
            if (id is null)
            {
                return NotFound();
            }
            OfficeEquipmentGym? officeEquipmentGym = await context.OfficeEquipmentsGym.FindAsync(id);
            if (officeEquipmentGym is null)
            {
                return NotFound();
            }
            return View(officeEquipmentGym);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, OfficeEquipmentGym officeEquipmentGym) 
        {
            if (!context.OfficeEquipmentsGym.Any(e => e.OfficeEquipmentGymId == id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                context.Update(officeEquipmentGym);
                await context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(officeEquipmentGym);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, OfficeEquipmentGym officeEquipmentGym)
        {
            if (context.OfficeEquipmentsGym.Any(e => e.OfficeEquipmentGymId == officeEquipmentGym.OfficeEquipmentGymId))
            {
                context.OfficeEquipmentsGym.Remove(officeEquipmentGym);
                await context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
