using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendasWebMVC2.Models;

namespace VendasWebMVC2.Data
{
    public class VendasWebMVC2Context : DbContext
    {
        public VendasWebMVC2Context (DbContextOptions<VendasWebMVC2Context> options)
            : base(options)
        {
        }

        public DbSet<VendasWebMVC2.Models.Departamentos> Departamentos { get; set; } = default!;
    }
}
