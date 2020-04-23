using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace Tienda.Datos
{
    public class Crud
    {

        //------------------------------------------------------------PRODUCTO-------------------------------------------------------------------//
        public void insertarProductos( string cod , string mar , string nom , decimal prec)
        {
            using (var contexto= new Clsbdcontext())
            {
                var productos = new Producto()
                {
                    Codigo = cod,
                    Marca = mar,
                    Nombre = nom,
                    Precio = prec
                };
                contexto.Producto.Add(productos);
                contexto.SaveChanges();
            }
        }
        public List<Producto> TraerProductos()
        {
            using ( Clsbdcontext cl = new Clsbdcontext())
            {
                List<Producto> lista = (from x in cl.Producto select x).ToList();
                return lista; 

            }
        }
        public void listarProductos()
        {
            foreach (Producto item in TraerProductos())
            {
                Console.WriteLine("[codigo ={0} , Marca={1} , Nombre={2} , Precio {3} " , item.Codigo,item.Marca,item.Nombre,item.Precio , "]" );
            }
        }
        //------------------------------------------------------------CLIENTE-------------------------------------------------------------------//

        public void insertarCliente(string dni, string nombr, string apellido, string direccion,string telefono)
        {
            using (var contexto = new Clsbdcontext())
            {
                var clientes = new Cliente()
                {
                    Dni = dni,
                    Nombre = nombr,
                    Apellido = apellido,
                    Direccion = direccion,
                    Telefono = telefono
                };
                contexto.Cliente.Add(clientes);
                contexto.SaveChanges();
            }
        }

        //------------------------------------------------------------VENTAS-------------------------------------------------------------------//

        public void VentasdelDia(int cliente, int producto,DateTime fecha)
        {
            using (var contexto = new Clsbdcontext())
            {
                var venta = new Venta()
                {
                    Cliente = cliente,
                    Producto=producto,
                    Fecha= fecha
                };
                contexto.Venta.Add(venta);
                contexto.SaveChanges();
            }
        }
        public List<Venta> TraerVentas(string fecha)
        {
            using (Clsbdcontext cl = new Clsbdcontext())
            {
                var query = (from x in cl.Venta where (x.Fecha == Convert.ToDateTime(fecha)) select x ).ToList();
                return query;

            }

        }
        public void listarVentas(string fecha)
        {
            foreach (Venta item in TraerVentas(fecha))
            {
                Console.WriteLine("[Cliente ={0} , Producto={1} , Fecha={2} ", item.Cliente, item.Producto, item.Fecha, "]");
            }
        }

        //------------------------------------------------------------BUSCARPRODUCTO-------------------------------------------------------------------//

        public List<Venta> SearchProduct (int search)
        {
            using (Clsbdcontext cl = new Clsbdcontext())
            {
                var query = (from x in cl.Venta where (x.Producto == search) select x).ToList();
                return query;
            }
        }
        public void PrintSearch (int it)
        {
            foreach (Venta item in SearchProduct(it))
            {
                Console.WriteLine("[Cliente ={0} , Producto={1} , Fecha={2} ", item.Cliente, item.Producto, item.Fecha, "]");
            }
        }
    }
}
