using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tienda.Datos
{
   public class Venta
    {
        private int ventasID;
        private int cliente;
        private int producto;
        private DateTime fecha;

      
        [Key]
        public int VentasID { get => ventasID; set => ventasID = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public int Producto { get => producto; set => producto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }


        public virtual Cliente Clientenavegator { get; set; }
        public virtual Producto productonavegator { get; set; }
        
    }
}
