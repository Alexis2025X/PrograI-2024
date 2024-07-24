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
       //Ejercicio obtener el promedio de una serie de numeros
            int[] serie = new int[] { 5, 4, 6, 8, 9 }; //matriz, esta se indica con []
            int suma = 0;
            foreach (int num in serie){
                suma = suma + num; //suma y asignación, tambien se puede hacer así: suma += num;
            }
            decimal prom = (suma / serie.Length);
            Console.WriteLine("La suma es: {0}, el promedio {1}", suma, prom); //m nos ayuda  a establecer decimales, Length da la logitud de una matriz

            //Hace una pausa en la consola lo cual nos permite leer lo que se imprime
            Console.ReadLine();
        }
    }
}
