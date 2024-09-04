using VendasWebMVC2.Models;
using VendasWebMVC2.Data;

namespace VendasWebMVC2.Services
{
    public class ServicoVendedor
    {
        private readonly VendasWebMVC2Context _context;

        public ServicoVendedor (VendasWebMVC2Context context)
        {
            _context = context;
        }

        public List<Vendedores> FindAll()
        {
           return _context.Vendedores.ToList();
        }

    }
}
