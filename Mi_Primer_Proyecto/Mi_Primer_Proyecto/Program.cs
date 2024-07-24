using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_Primer_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean comprobar = true;
            Console.WriteLine("El valor es: {0}", comprobar);

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola {0} bienvenido", nombre);

            DateTime fechaActual = new DateTime();
            fechaActual = DateTime.Now;
            Console.WriteLine("La fecha actual es: {0}", fechaActual);

            //Hace una pausa en la consola lo cual nos permite leer lo que se imprime
            Console.ReadLine();
        }
    }
}
