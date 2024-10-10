using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeGym.Data;
using OfficeGym.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [HttpGet]
        public async Task<IActionResult> Create() 
        {
            var employees = await (from e in context.Employees
                                 select new
                                 {
                                     EmployeeId = e.EmployeeId,
                                     Name = e.FirstName + " " + e.LastName
                                 }).ToListAsync();

            ViewBag.EmployeesSelectList = new SelectList(employees, "EmployeeId", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Vacation vacation)
        {
            if (ModelState.IsValid)
            {
                context.Vacations.Add(vacation);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            var employees = await (from e in context.Employees
                                   select new
                                   {
                                       EmployeeId = e.EmployeeId,
                                       Name = e.FirstName + " " + e.LastName
                                   }).ToListAsync();

            ViewBag.EmployeesSelectList = new SelectList(employees, "EmployeeId", "Name", vacation.EmployeeId);
            
            return View(vacation);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id) 
        {
            if (id is null)
            {
                return NotFound();
            }
            Vacation? vacation = await context.Vacations.FindAsync(id);
            if (vacation is null)
            {
                return NotFound();
            }

            var employees = await (from e in context.Employees
                                   select new
                                   {
                                       EmployeeId = e.EmployeeId,
                                       Name = e.FirstName + " " + e.LastName
                                   }).ToListAsync();

            ViewBag.EmployeesSelectList = new SelectList(employees, "EmployeeId", "Name", vacation.EmployeeId);

            return View(vacation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Vacation vacation) 
        {
            if (id is null || !await context.Vacations.AnyAsync(e => e.VacationId == id)) 
            {
                return NotFound();
            }

            if (ModelState.IsValid) 
            {
                context.Vacations.Update(vacation);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            var employees = await (from e in context.Employees
                                   select new
                                   {
                                       EmployeeId = e.EmployeeId,
                                       Name = e.FirstName + " " + e.LastName
                                   }).ToListAsync();

            ViewBag.EmployeesSelectList = new SelectList(employees, "EmployeeId", "Name", vacation.EmployeeId);

            return View(vacation);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, Vacation vacation) 
        {
            if (await context.Vacations.AnyAsync(e => e.VacationId == vacation.VacationId))
            {
                context.Vacations.Remove(vacation);
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
