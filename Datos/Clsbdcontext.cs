using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.Datos
{
   public  class Clsbdcontext: DbContext
    {
        private DbSet<Cliente> cliente;
        private DbSet<Producto> producto;
        private DbSet<Venta> venta;

        public DbSet<Cliente> Cliente { get => cliente; set => cliente = value; }
        public DbSet<Producto> Producto { get => producto; set => producto = value; }
        public DbSet<Venta> Venta { get => venta; set => venta = value; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-T7L4FG6;Database=tienda;Trusted_Connection=True;");
        }
    }
}
