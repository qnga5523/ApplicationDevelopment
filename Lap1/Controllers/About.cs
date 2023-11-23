using Microsoft.AspNetCore.Mvc;

namespace Lap1.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
