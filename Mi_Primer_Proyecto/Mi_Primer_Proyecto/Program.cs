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
            //Uso de matrices
            double[,] matriz = new double[,] {
                {0.01, 472.00, 0, 0}, //Tramo I
                {472.01,  895.24,  10,  17.67}, //Tramo II
                {895.25,  2038.10, 20,  60.00}, //Tramo III
                {2038.11, 9999999, 30, 288.57}, //Tramo IV
            };
            Console.Write("Sueldo: ");
            double sueldo = double.Parse(Console.ReadLine()),
                afp = sueldo * 7.25 / 100,
                isss = sueldo * 3 / 100,
               
                isr = 0;


            //Console.WriteLine(isss + " " + afp);
            /*
            for (int j = 0; j < 4; j++)
            {
                if (sueldo >= matriz[j, 0] && sueldo <= matriz[j, 1])
                {
                    afp = (sueldo -(32.51 + 15.60));
                }
                else
                {
                    afp = (sueldo - (50.00 + 24.00));
                }
            }
            */

            sueldo -= afp;
            
            
            for (int i = 0; i < 4; i++)
            {
                if (sueldo >= matriz[i, 0] && sueldo <= matriz[i, 1])
                {
                    isr = (sueldo - (matriz[i, 0] - 0.01)) * matriz[i, 2] / 100 + matriz[i, 3];
                }
            }
            
             sueldo -= isss;
             sueldo -= isr;
            Console.WriteLine(isss + " " + isr + "\n");
             Console.WriteLine("Sueldo Neto: {0}, AFP: {1}, ISSS: {2}, ISR: {3}", Math.Round(sueldo, 2), afp, isss, Math.Round(isr, 2));

             Console.ReadLine();

        }
    }
}
