using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.Datos
{
   public class Producto
    {
        private int productoId;
        private string codigo;
        private string marca;
        private string nombre;
        private decimal precio;

        public int ProductoId { get => productoId; set => productoId = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
