using Microsoft.AspNetCore.Mvc;

namespace WebEscuelaMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Saludo = "Bienvenido!";
            return View();
        }
    }
}
