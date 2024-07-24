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
            //Prioridad de los operadores aritmeticos.
            //se pone el sufijo m para la division con decimales.
            decimal respuesta = 5 + 8 - 2 * 5 / 4m + 1;
            Console.WriteLine("La respuesta es: {0}", respuesta);

            Console.WriteLine("La division de 5/4 es {0}", 5 / 4);

            //Hace una pausa en la consola lo cual nos permite leer lo que se imprime
            Console.ReadLine();
        }
    }
}
