using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RubiaDivina.Models;

namespace RubiaDivina.Data
{
    public class RubiaDivinaContext : DbContext
    {
        public RubiaDivinaContext (DbContextOptions<RubiaDivinaContext> options)
            : base(options)
        {
        }

        public DbSet<RubiaDivina.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<RubiaDivina.Models.Categoria> Categoria { get; set; } = default!;
        public DbSet<RubiaDivina.Models.Producto> Producto { get; set; } = default!;
        public DbSet<RubiaDivina.Models.Pedido> Pedido { get; set; } = default!;
        public DbSet<RubiaDivina.Models.Factura> Factura { get; set; } = default!;
    }
}
