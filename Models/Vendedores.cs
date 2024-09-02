using VendasWebMVC2.Models;
using System.Linq;

namespace VendasWebMVC2.Models
{
    public class Vendedores
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Valores { get; set; }
        public Departamentos? Departamentos { get; set; }

        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();
 

        public Vendedores()
        {

        }

        public Vendedores(int id, string nome, string email, DateTime dataNascimento, Double  valores, Departamentos departamentos)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Valores = valores;
            Departamentos = departamentos;
        }

        public void AddVenda(RegistroVendas reg)=>Vendas.Add(reg);

        public void RemoveVenda(RegistroVendas rv)=>Vendas.Remove(rv);

        public double TotalVendas(DateTime inicial , DateTime final)
        {
            return Vendas.Where(rv => rv.Date >= inicial && rv.Date <= final).Sum(rv => rv.Valor);
        }

        internal void AddVendedores(Vendedores vendedor)
        {
            throw new NotImplementedException();
        }
    }
}
