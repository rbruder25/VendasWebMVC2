using VendasWebMVC2.Models;
using System.Linq;
using VendasWebMVC2.Models.Enums;
namespace VendasWebMVC2.Data
{
    public class SeedingService
    {
        private VendasWebMVC2Context _context;


        public SeedingService(VendasWebMVC2Context context) => _context = context;


        public void Seed()
        {
         
            if (_context.Departamentos.Any() || _context.Vendedores.Any() || _context.RegistroVendas.Any())
            {
                return; // Banco de dados já populado
            }
        

            Departamentos  d1 = new Departamentos(1,"Computer");
            Departamentos  d2 = new Departamentos(2,"Eletronico");
            Departamentos  d3 = new Departamentos(3,"Fachion");
            Departamentos  d4 = new Departamentos(4,"Livraria");


            Vendedores v1 = new Vendedores(1, "Antonio Alves", "antonu@gmail.com", new DateTime(1998, 4, 21), 1000.00, d1);
            Vendedores v2 = new Vendedores(2, "Mario Pedroso", "mario@gmail.com", new DateTime(1988, 5, 23), 2000.00, d2);
            Vendedores v3 = new Vendedores(3, "Carla Silveira", "carla@gmail.com", new DateTime(1978, 8, 18), 3000.00, d3);
            Vendedores v4 = new Vendedores(4, "Jose Matheus", "jose@gmail.com", new DateTime(1968, 7, 24), 4000.00, d4);
            Vendedores v5 = new Vendedores(5, "Alice Menezes", "alice@gmail.com", new DateTime(1967, 6, 22), 1000.00, d1);
            Vendedores v6 = new Vendedores(6, "Wagner Santiago", "wagnere@gmail.com", new DateTime(1966, 5, 25), 1000.00, d1);

            RegistroVendas r1 = new RegistroVendas(1, new DateTime(2024, 2, 22), 1500.00, StatusValor.Billed, v1);
            RegistroVendas r2 = new RegistroVendas(2, new DateTime(2024, 2, 23), 1500.00, StatusValor.Billed, v2);
            RegistroVendas r3 = new RegistroVendas(3, new DateTime(2024, 2, 24), 1500.00, StatusValor.Billed, v3);
            RegistroVendas r4 = new RegistroVendas(4, new DateTime(2024, 2, 25), 1500.00, StatusValor.Billed, v4);
            RegistroVendas r5 = new RegistroVendas(5, new DateTime(2024, 2, 26), 1500.00, StatusValor.Billed, v5);
            RegistroVendas r6 = new RegistroVendas(6, new DateTime(2024, 2, 27), 1500.00, StatusValor.Billed, v6);
            RegistroVendas r7 = new RegistroVendas(7, new DateTime(2024, 2, 28), 1500.00, StatusValor.Billed, v1);
            RegistroVendas r8 = new RegistroVendas(8, new DateTime(2024, 2, 29), 1500.00, StatusValor.Billed, v2);
            RegistroVendas r9 = new RegistroVendas(9, new DateTime(2024, 2, 28), 1500.00, StatusValor.Billed, v1);
            RegistroVendas r10 = new RegistroVendas(10, new DateTime(2024, 2, 1), 1500.00, StatusValor.Billed, v2);
            RegistroVendas r11 = new RegistroVendas(11, new DateTime(2024, 2, 2), 1500.00, StatusValor.Billed, v3);
            RegistroVendas r12 = new RegistroVendas(12, new DateTime(2024, 2, 3), 1500.00, StatusValor.Billed, v4);
            RegistroVendas r13 = new RegistroVendas(13, new DateTime(2024, 2, 4), 1500.00, StatusValor.Billed, v5);
            RegistroVendas r14 = new RegistroVendas(14, new DateTime(2024, 2, 5), 1500.00, StatusValor.Billed, v6);
            RegistroVendas r15 = new RegistroVendas(15, new DateTime(2024, 2, 6), 1500.00, StatusValor.Billed, v1);
            RegistroVendas r16 = new RegistroVendas(16, new DateTime(2024, 2, 7), 1500.00, StatusValor.Billed, v2);
            RegistroVendas r17 = new RegistroVendas(17, new DateTime(2024, 2, 8), 1500.00, StatusValor.Billed, v4);
            RegistroVendas r18 = new RegistroVendas(18, new DateTime(2024, 2, 9), 1500.00, StatusValor.Billed, v5);
            RegistroVendas r19 = new RegistroVendas(19, new DateTime(2024, 2, 12), 1500.00, StatusValor.Billed, v6);
            RegistroVendas r20 = new RegistroVendas(20, new DateTime(2024, 2, 12), 1500.00, StatusValor.Billed, v1);
            RegistroVendas r21 = new RegistroVendas(21, new DateTime(2024, 2, 13), 1500.00, StatusValor.Billed, v1);
            RegistroVendas r22 = new RegistroVendas(22, new DateTime(2024, 2, 14), 1500.00, StatusValor.Billed, v3);
            RegistroVendas r23 = new RegistroVendas(23, new DateTime(2024, 2, 15), 1500.00, StatusValor.Billed, v4);
            RegistroVendas r24 = new RegistroVendas(24, new DateTime(2024, 2, 16), 1500.00, StatusValor.Billed, v5);
            RegistroVendas r25 = new RegistroVendas(25, new DateTime(2024, 2, 17), 1500.00, StatusValor.Billed, v6);
            RegistroVendas r26 = new RegistroVendas(26, new DateTime(2024, 2, 18), 1500.00, StatusValor.Billed, v1);
            RegistroVendas r27 = new RegistroVendas(27, new DateTime(2024, 2, 19), 1500.00, StatusValor.Billed, v2);
            RegistroVendas r28 = new RegistroVendas(28, new DateTime(2024, 2, 22), 1500.00, StatusValor.Billed, v3);
            RegistroVendas r29 = new RegistroVendas(29, new DateTime(2024, 2, 22), 1500.00, StatusValor.Billed, v4);
            RegistroVendas r30 = new RegistroVendas(30, new DateTime(2024, 2, 22), 1500.00, StatusValor.Billed, v5);


            _context.Departamentos.AddRange(d1,d2,d3,d4);
            _context.Vendedores.AddRange(v1,v2,v3,v4,v5,v6);
            _context.RegistroVendas.AddRange(r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,
                                             r15,r16,r17,r18,r19,r20,r21,r22,r23,r24,r25,r26,
                                             r27,r28,r29,r30);

            _context.SaveChanges();
        }
    }
}
