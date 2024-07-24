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
            //Ejercicio de obtener la nota final de la materia de Programacion I.
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1: ");
            double parcial1 = double.Parse(Console.ReadLine()); //7

            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", c1);

            //Hace una pausa en la consola lo cual nos permite leer lo que se imprime
            Console.ReadLine();
        }
    }
}
