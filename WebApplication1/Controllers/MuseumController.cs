using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MuseumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Exhibits()
        {
            return View();
        }
        public IActionResult Exhibitions()
        {
            return View();
        }
        public IActionResult Tickets()
        {
            return View();
        }
    }
}
