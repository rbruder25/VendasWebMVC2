using VendasWebMVC2.Models.Enums;
using VendasWebMVC2.Models;
namespace VendasWebMVC2.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Valor { get; set; }
        public StatusValor status { get; set; }
        public Vendedores? Vendedores { get; set; }

      

        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime date, double valor, StatusValor status, Vendedores vendedores)
        {
            Id = id;
            Date = date;
            Valor = valor;
            this.status = status;
            Vendedores = vendedores;
        }


    }
}
