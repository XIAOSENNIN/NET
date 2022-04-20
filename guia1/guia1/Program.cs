using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace guia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }

        ///
        /// / ejercicio 1
        ///
        static void Ejercicio1()
        {

            int n1;
            int n2;
            int n3;
            int n4;
            int n5;

            Console.Write("ingrese nota 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("ingrese nota2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("ingrese nota3: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("ingrese nota4: ");
            n4 = int.Parse(Console.ReadLine());

            Console.Write("ingrese nota5: ");
            n5 = int.Parse(Console.ReadLine());

            int resultado = n1 + n2 + n3 + n4 + n5;
            int promedio = resultado / 5;

            if (promedio > 40)
            {
                Console.WriteLine("Aprobao con un promedio: " + promedio);
            }
            else
            {
                Console.WriteLine("Reprobado con un: " + promedio);
            }

        }

        /// 
        /// ejercicio 2
        /// 


        static void Ejercicio2()
        {
            int n1;
            int n2;
            int n3;

            Console.Write("ingrese num 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("ingrese num 2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("ingrese num 3: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine("el numero menor es: " + n1);
            }
            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine("el numero menor es: " + n2);
            }
            else if (n3 < n1 && n3 < n2)
            {
                Console.WriteLine("el numero menor es: " + n3);
            }
        }

        /// 
        /// ejercicio 3
        /// 
        static void Ejercicio3()
        {
            int numero;

            Console.Write("ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            int resto = numero % 2;
            if (resto == 0)
            {
                Console.WriteLine("es par");
            }
            else
            {
                Console.WriteLine("es impar");
            }
        }

        /// 
        /// ejercicio 41
        /// 

        static void Ejercicio4()
        {
            int cargo_fijo = 30000;
            int hasta300km = 100;
            int sobre300km = 80;
            int sobre1000km = 60;

            int kms;
            int iva;
            int total;

            Console.Write("ingresa km recorrio: ");
            kms = int.Parse(Console.ReadLine());

            if (kms <= 300)
            {
                cargo_fijo = cargo_fijo + (kms * hasta300km);
                Console.WriteLine("Kilometros recorridos: " + kms);

                Console.WriteLine("Valor recorrido: " + cargo_fijo);
                iva = (cargo_fijo * 19) / 100;
                Console.WriteLine("IVA DE: " + iva);
                total = cargo_fijo + iva;
                Console.WriteLine("Total a pagar; " + total); 

            }
            else if (kms > 300 && kms <= 1000)
            {
                cargo_fijo = cargo_fijo + (kms * sobre300km);

                Console.WriteLine("Kilometros recorridos: " + kms);

                Console.WriteLine("Valor recorrido: " + cargo_fijo);
                iva = (cargo_fijo * 19) / 100;
                Console.WriteLine("IVA DE: " + iva);
                total = cargo_fijo + iva;
                Console.WriteLine("Total a pagar; " + total);

            }
            else if (kms > 1000)
            {
                cargo_fijo = cargo_fijo + (kms * sobre1000km);

                Console.WriteLine("Kilometros recorridos: " + kms);

                Console.WriteLine("Valor recorrido: " + cargo_fijo);
                iva = (cargo_fijo * 19) / 100;
                Console.WriteLine("IVA DE: " + iva);
                total = cargo_fijo + iva;
                Console.WriteLine("Total a pagar; " + total);

            }


        }
    }
}
