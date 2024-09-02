using System.Collections.Generic;
using System;
using System.Linq;
using VendasWebMVC2.Models;


namespace VendasWebMVC2.Models

{
    public class Departamentos
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public ICollection<Vendedores> Vendedores { get; set; } = new List<Vendedores>();
    
        public Departamentos()
        {

        }

        public Departamentos(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedores vendedor)
        {

            Vendedores.Add(vendedor);
        }
       


        public double TotalVendas(DateTime inicial,DateTime final)
        {
            return Vendedores.Sum(vendedor => vendedor.TotalVendas(inicial, final));
        }


    }

}
