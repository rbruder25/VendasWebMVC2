using Microsoft.AspNetCore.Mvc;

namespace VendasWebMVC2.Controllers
{
    public class VendedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
