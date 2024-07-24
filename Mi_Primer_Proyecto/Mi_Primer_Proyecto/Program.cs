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
            Console.WriteLine("Computo I");

            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1: ");
            double parcial1 = double.Parse(Console.ReadLine());

            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", c1);

            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("Computo II");

            Console.Write("lab1: ");
            double lab1II = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            double lab2II = double.Parse(Console.ReadLine());

            Console.Write("Parcial 2: ");
            double parcial2 = double.Parse(Console.ReadLine());

            double c2 = lab1II * 30 / 100 + lab2II * 30 / 100 + parcial2 * 40 / 100;
            Console.WriteLine("La nota de C2 es: {0}", c2);

            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("Computo II");

            Console.Write("lab1: ");
            double lab1III = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            double lab2III = double.Parse(Console.ReadLine());

            Console.Write("Parcial 3: ");
            double parcial3 = double.Parse(Console.ReadLine());

            double c3 = lab1III * 30 / 100 + lab2III * 30 / 100 + parcial3 * 40 / 100;
            Console.WriteLine("La nota de C3 es: {0}", c3);

            double Notafinal = Math.Round(((c1 + c2 + c3) / 3), 1);
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("La nota final de la asignatura es: {0}", Notafinal);

            if (Notafinal < 6)
                Console.WriteLine("Usted a reprobado");
            else
                Console.WriteLine("Felicidades usted a aprobado");


            //Hace una pausa en la consola lo cual nos permite leer lo que se imprime
            Console.ReadLine();
        }
    }
}
