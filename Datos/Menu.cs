using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Tienda.Datos
{
    class Menu
    {
        private Datos.Crud consulta;

        public Menu()
        {
            consulta = new Datos.Crud();
        }
        public void menuprincipal()
        {
            try
            {
                int opcion;
                do
                {
                    Console.ReadKey();
                    Console.Clear();


                    Console.WriteLine("-------TIENDA ONLINE------");
                    Console.WriteLine("Elija una opcion");
                    Console.WriteLine();
                    Console.WriteLine("1).Cargar productos a la base de datos");
                    Console.WriteLine("2).Listar Productos de la base de datos");
                    Console.WriteLine("3).Ventas del dia");
                    Console.WriteLine("4).Reportes");
                    Console.WriteLine("5).Buscar Productos");
                    Console.WriteLine("6).Registrar Cliente");
                    Console.WriteLine("7).salir");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            {

                                ingresarProducto();
                                break;

                            }
                        case 2:
                            {
                                consulta.listarProductos();
                                consulta.TraerProductos();

                                break;
                            }
                        case 3:
                            {
                                ventasdelDia();
                                break;
                            }
                        case 4:
                            {

                                Reportes();
                                break;
                            }
                        case 5:
                            {

                                busqueda();
                                break;
                            }
                        case 6:
                            {
                                usuario();
                                break;
                            }
                        case 7:
                            {

                                break;
                            }


                    }

                }
                while (opcion != 7);
            }
            catch(Exception e )
            {
                Console.WriteLine(e.Message.ToString());
            }


        }
        public void ingresarProducto()
        {
            try
            {
                Console.WriteLine("CODIGO : ");
                string cod = Console.ReadLine();
                Console.WriteLine("MARCA : ");
                string mar = Console.ReadLine();
                Console.WriteLine("NOMBRE : ");
                string nombre = Console.ReadLine();
                Console.WriteLine("PRECIO : ");
                decimal prec = decimal.Parse(Console.ReadLine());
                consulta.insertarProductos(cod, mar, nombre, prec);
            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message.ToString());
            }
        
        }
        public void ventasdelDia()
        {
            try
            {
                Console.WriteLine("CLIENTE : ");
                int cliente = int.Parse(Console.ReadLine());
                Console.WriteLine("PRODUCTO : ");
                int producto = int.Parse(Console.ReadLine());
                Console.WriteLine("INGRESE FECHA CON FORMATO MM/DD/YYYY");
                string datestring = Console.ReadLine();
                string format = "MM/DD/YYYY";
                DateTime fecha = DateTime.ParseExact(datestring, format, CultureInfo.InvariantCulture);

                consulta.VentasdelDia(cliente, producto, fecha);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
          
        }
        public void Reportes()
        {
            try
            {
                Console.WriteLine("VENTAS DEL DIA [INGRESE FECHA FORMATO DD/MM/AAAA] ");
                string datestring = Console.ReadLine();
                consulta.TraerVentas(datestring);
                consulta.listarVentas(datestring);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
           
        }
        public void busqueda()
        {
            try
            {
                Console.WriteLine("INGRESE EL CODIGO DEL PRODUCTO : ");
                int producto = int.Parse(Console.ReadLine());
                consulta.SearchProduct(producto);
                consulta.PrintSearch(producto);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
        public void usuario()
        {
            try
            {
                Console.WriteLine("DNI : ");
                string dni = Console.ReadLine();
                Console.WriteLine("NOMBRE : ");
                string nombre = Console.ReadLine();
                Console.WriteLine("APELLIDO : ");
                string Apellido = Console.ReadLine();
                Console.WriteLine("DIRECCION : ");
                string Direccion = Console.ReadLine();
                Console.WriteLine("TELEFONO : ");
                string telefono = Console.ReadLine();
                consulta.insertarCliente(dni, nombre, Apellido, Direccion, telefono);
            }
            catch ( Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}
