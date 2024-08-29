using Microsoft.AspNetCore.Mvc;

namespace OfficeGym.Controllers
{
    public class VacationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
