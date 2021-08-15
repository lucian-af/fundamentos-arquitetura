using Microsoft.AspNetCore.Mvc;

namespace Desenvolvedor.IO.DI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
