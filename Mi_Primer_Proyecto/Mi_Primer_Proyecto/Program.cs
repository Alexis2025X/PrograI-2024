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

            //Uso de funciones y matrices
            //Ejercicio para encontrar la media aritmetica en la desviación tipica de una serie de numeros

            int[] serie = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("La media aritmetica es: {0}, y la desviación tipica es: {1}", media(serie), tipica(serie));

            Console.ReadLine();
           
        }
        static double media(int[] serie)
        {
            double media = 0;
            foreach(int num in serie)
            {
                media += num;
            }
            return media / serie.Length;
                
        }
        static double tipica(int[] serie)
        {
            double tipica = 0;
            double m = media(serie);
            foreach (int num in serie)
            { // Math.Pow eleva a la potencia que querramos
                tipica += Math.Pow(num - m, 2);
            }
            //Math.Sqrt es para raíz cuadrada
            tipica = Math.Sqrt(tipica / serie.Length);
            tipica = Math.Round(tipica);

            return tipica;
        }
    }
}
