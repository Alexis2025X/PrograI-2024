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
            //Ejercicio para encontrar la media aritmetica en la desviación tipica de una serie de numeros + media armonica
            Console.Write("Ingrese los numeros separados por comas: ");
            String serie = Console.ReadLine();
            //Split separa los numeros y crea una matriz
            String[] numeros = serie.Split(',');

            Console.WriteLine("La media aritmetica es: {0}, la desviación tipica es: {1} y la armonica es: {2}", media(numeros), tipica(numeros), armonicass(numeros));

            Console.ReadLine();
           
        }
        static double media(string[] serie)
        
            {
            double media = 0;
            foreach (string num in serie)
            {
                media += int.Parse(num);
            }
            return media / serie.Length;
                
        }

        static double tipica(string[] serie)
        {
            double tipica = 0;

            double m = media(serie);
            foreach (String num in serie)
            { // Math.Pow eleva a la potencia que querramos
                tipica += Math.Pow(int.Parse(num) - m, 2);
            }
            //Math.Sqrt es para raíz cuadrada
            tipica = Math.Sqrt(tipica / serie.Length);
            tipica = Math.Round(tipica);

            return tipica;
        }
        static double armonicass(string[] serie)
        {
            int n = serie.Length;
            double armonica = 0;

            double m = media(serie);
            foreach (String num in serie)
            { 
                armonica += 1 / int.Parse(num);

            }
          
            armonica = n / armonica;
         

            return armonica;
        }
    }
}
