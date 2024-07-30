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
            //Estructuras de control
            //1.If. Ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido al mundo de las responsabilidades");
            }
            else
            {
                    Console.WriteLine("Eres un adolescente");
            }

            //Hace una pausa en la consola lo cual nos permite leer lo que se imprime
            Console.ReadLine();
        }
    }
}
