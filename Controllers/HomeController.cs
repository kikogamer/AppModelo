using Microsoft.AspNetCore.Mvc;

namespace Kiko.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}