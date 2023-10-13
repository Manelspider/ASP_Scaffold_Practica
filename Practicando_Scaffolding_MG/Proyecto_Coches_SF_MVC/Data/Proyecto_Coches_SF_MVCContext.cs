using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaScaffold.Models;

namespace Proyecto_Coches_SF_MVC.Data
{
    public class Proyecto_Coches_SF_MVCContext : DbContext
    {
        public Proyecto_Coches_SF_MVCContext (DbContextOptions<Proyecto_Coches_SF_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<PruebaScaffold.Models.Car> Car { get; set; } = default!;
    }
}
