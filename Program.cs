using System;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos.Menu menu = new Datos.Menu();
            menu.menuprincipal();
            Console.ReadKey();
            
        }
    }
}
