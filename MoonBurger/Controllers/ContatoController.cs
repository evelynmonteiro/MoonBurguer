using Microsoft.AspNetCore.Mvc;

namespace MoonBurger.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
