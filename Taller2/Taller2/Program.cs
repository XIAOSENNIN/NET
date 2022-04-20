using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taller2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio1();
            ejercicio2();
            ejercicio3();
            ejercicio4();
            ejercicio5();
            ejercicio6();
            ejercicio7();
            ejercicio8();
        }

        static void ejercicio1()
        {
            int numero;

            Console.Write("escriba un numero: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void ejercicio2()
        {
            int numero;

            Console.Write("escriba un numero: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = numero; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void ejercicio3()
        {
            int numero;
            int res = 0;
            Console.Write("escriba un numero: ");
            numero = int.Parse(Console.ReadLine());


            for (int i = 1; i <= numero; i++)
            {
                res = res + i;
                Console.WriteLine(res);
            }
        }

        //static void ejercicio3_alt()
        //{
        //    int numero;
        //    Console.Write("escriba un numero: ");
        //    numero = int.Parse(Console.ReadLine());

        //    for (int i = 1; i <= numero; i++)
        //    {
        //        int res = i + numero;
        //        Console.WriteLine(i + " + " + numero + " = " + res);
        //    }
        //}

        static void ejercicio4()
        {
            int numero;
            Console.Write("escriba un numero: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }

        static void ejercicio5()
        {
            int numero;
            Console.Write("escriba un numero: ");
            numero = int.Parse(Console.ReadLine());
            int impar = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    impar += i;
                }

            }
            Console.WriteLine("La suma de los impares es: " + impar);
        }

        static void ejercicio6()
        {
            Console.Write("Ingrese cuantos numeros desea promediar: ");
            int ask = int.Parse(Console.ReadLine());
            double nums;
            double totalsuma = 0;
            double prom = 0;
            for (int i = 0; i < ask; i++)
            {
                Console.Write("Ingrese numero: ");
                nums = double.Parse(Console.ReadLine());
                totalsuma += nums;

            }
            prom = totalsuma / ask;
            Console.WriteLine("El promedio es: " + prom);
        }

        static void ejercicio7()
        {
            int num1, num2;
            Console.Write("Ingrese el primero numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());


            if (num2 > num1)
            {
                Console.WriteLine("pares entre numero 1 y num2: ");
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            } else
            {
                Console.WriteLine("El numero 2 debe ser mayor al num1");
            }
        }

        static void ejercicio8()
        {
            int num1, num2;
            double dnum1, dnum2;

            bool salir = false;

            while (salir == false)
            {
                Console.WriteLine("---------- MENU -------------");
                Console.WriteLine("1.- Sumar ");
                Console.WriteLine("2.- Resta");
                Console.WriteLine("3.- Multiplicación");
                Console.WriteLine("4.- División");
                Console.WriteLine("5.- Salir\n");

                Console.Write("Escoja una opción: ");

                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Write("Ingrese num 1: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese num 2: ");
                        num2 = int.Parse(Console.ReadLine());

                        suma(num1, num2);
                        break;

                    case 2:
                        Console.Write("Ingrese num 1: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese num 2: ");
                        num2 = int.Parse(Console.ReadLine());

                        resta(num1, num2);
                        break;

                    case 3:
                        Console.Write("Ingrese num 1: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese num 2: ");
                        num2 = int.Parse(Console.ReadLine());

                        multi(num1, num2);
                        break;

                    case 4:
                        Console.Write("Ingrese num 1: ");
                        dnum1 = double.Parse(Console.ReadLine());

                        Console.Write("Ingrese num 2: ");
                        dnum2 = double.Parse(Console.ReadLine());

                        div(dnum1, dnum2);
                        break;

                    case 5:
                        salir = true;
                        Console.WriteLine("chaolin\n");
                        break;
                    default:
                        Console.WriteLine("Escoja un numero válido");
                        break;
                }
            }
        }

        static int suma(int num1, int num2)
        {
            int suma = num1 + num2;
            Console.WriteLine("El resultado es: " +suma);
            return suma;
        }

        static int resta(int num1, int num2)
        {
            int resta = num1 - num2;
            Console.WriteLine("El resultado es: " + resta);
            return resta;
        }
        static int multi(int num1, int num2)
        {
            int multi = num1 * num2;
            Console.WriteLine("El resultado es: " + multi);
            return multi;
        }
        static double div(double num1, double num2)
        {
            double div = num1 / num2;
            Console.WriteLine("El resultado es: " + div);
            return div;
        }
    }
}
