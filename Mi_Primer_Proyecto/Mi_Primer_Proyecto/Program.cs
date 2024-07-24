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
            //Ejercicio de suma de dos numeros introducidos por el usuario
            Console.Write("Num 1: ");
            double num1 = double.Parse(Console.ReadLine()); //"5" -> 5
            //.Parse transforma la cadena a numero
            Console.Write("Num 2: ");
            double num2 = double.Parse(Console.ReadLine());

            double respuesta = num1 + num2;
            Console.WriteLine("La suma de {0}+{1}={2}", num1, num2, respuesta);

            //Hace una pausa en la consola lo cual nos permite leer lo que se imprime
            Console.ReadLine();
        }
    }
}
