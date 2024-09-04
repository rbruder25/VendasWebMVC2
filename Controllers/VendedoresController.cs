using Microsoft.AspNetCore.Mvc;
using VendasWebMVC2.Services;

namespace VendasWebMVC2.Controllers
{
    public class VendedoresController : Controller
    {

        private readonly ServicoVendedor? _servicoVendedor;

        public VendedoresController(ServicoVendedor? servicoVendedor)
        {
            _servicoVendedor = servicoVendedor;

        }
        public IActionResult Index()
        {
            var list = _servicoVendedor.FindAll();
            return View(list);
        }
    }
}
