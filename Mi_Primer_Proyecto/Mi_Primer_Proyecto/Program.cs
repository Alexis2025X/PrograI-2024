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
            string continuar = "s";
            while (continuar == "s") { 
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 0)
            {
                Console.WriteLine("Edada incorrecta");
            }else if (edad <= 2){
                Console.WriteLine("Eres un bebe");
            }else if (edad < 12) {
                Console.WriteLine("Eres un niño");
            }else if (edad < 18) {
                Console.WriteLine("Eres un adolescente");
            }else if (edad < 65) {
                Console.WriteLine("Bienvenido al mundo de las responsabilidades");
            }else if (edad < 80) {
                Console.WriteLine("Eres un adulto mayor");
            }else {
                 Console.WriteLine("Larga vida");
            }

            Console.Write("Desea continuar? si desea continuar presione s sino quiere continuar pr ");
                //Continuar
                continuar = Console.ReadLine();
             }

            }
        }
}
