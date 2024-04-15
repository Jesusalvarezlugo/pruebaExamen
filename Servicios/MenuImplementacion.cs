using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaExamen.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionS;
            Console.WriteLine("###################");
            Console.WriteLine("0. Salir de la aplicacion.");
            Console.WriteLine("1. Registro Vehiculo.");
            Console.WriteLine("2. Control acceso");
            Console.WriteLine("3. PIF");
            Console.WriteLine("###################");
            Console.WriteLine("Introduce una opcion: ");
            opcionS=Console.ReadKey(true).KeyChar - '0';

            return opcionS;
        }
    }
}
