using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicioPrueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio1();
        }

        static void ejercicio1()
        {
            double desc_salud;
            double desc_afp;

            int bono = 0;
            double sueldoLiquido = 0;

            Console.Write("Registre la cantidad de trabajadores: ");
            int trabajadores = int.Parse(Console.ReadLine());

            string[] nombres = new string[trabajadores];
            int[] sueldoBruto = new int[trabajadores];

            for (int i = 0; i < trabajadores; i++)
            {
                Console.Write("Ingrese nombre del trabajador {0}: ", i + 1);
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese sueldo del trabajador {0}: ", i + 1);
                sueldoBruto[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < trabajadores; i++)
            {
                desc_salud = (7 * sueldoBruto[i]) / 100;
                desc_afp = (12 * sueldoBruto[i]) / 100;

                if (sueldoBruto[i] <= 350000)
                {
                    bono = 55000;
                    sueldoLiquido = (sueldoBruto[i] - desc_salud - desc_afp + bono);
                }
             
                else if ((sueldoBruto[i] > 350000) && (sueldoBruto[i] <= 1150000))
                {
                    bono = 35000;
                    sueldoLiquido = (sueldoBruto[i] - desc_salud - desc_afp + bono);
                }
                else
                {
                    bono = 0;
                    sueldoLiquido = (sueldoBruto[i] - desc_salud - desc_afp + bono);
                }

               
                Console.WriteLine("Nombre: {0}, Sueldo Bruto: {1}, % Salud: {2}, % AFP: {3} Bono: {4}, Sueldo liquido: {5}", nombres[i], sueldoBruto[i], desc_salud, desc_afp, bono, sueldoLiquido);

            }


        }
    }
}
