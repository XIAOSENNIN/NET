using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejerciciosOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio1();
            //Dado miDado = new Dado();
            //miDado.arrojarDado();

            //ejercicio3();

            auto micar = new auto();
            micar.identificarVehiculo();    
            avion airp = new avion();
            airp.identificarVehiculo();

            Console.ReadKey();
        }

        static void ejercicio1()
        {
            Console.Write("Ingrese cantidad de alumnos: ");
            int cantidad = int.Parse(Console.ReadLine());

            int[] rut = new int[cantidad];
            string[] nombre = new string[cantidad];
            int[] nota = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese rut para alumno {0}: ", i + 1);
                rut[i] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese nombre para alumno {0}: ", i + 1);
                nombre[i] = Console.ReadLine();

                Console.Write("Ingrese nota para alumno {0}: ", i + 1);
                nota[i] = int.Parse(Console.ReadLine());
            }

            int menor = nota[0];
            int mayor = nota[0];

            int indicemenor = 0;
            int indicemayor = 0;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(rut[i] + " " + nombre[i] + " " + nota[i]);

                if (nota[i] < menor)
                {
                    menor = nota[i];
                    indicemenor = i;
                }
                if (nota[i] > mayor)
                {
                    mayor = nota[i];
                    indicemayor = i;
                }
            }
            Console.WriteLine("El alumno con la nota menor es: " + nombre[indicemenor]);
            Console.WriteLine("El alumno con la nota mayor es: " + nombre[indicemayor]);
        }

        static void ejercicio3()
        {
         
            
            bool salir = false;
            int n1 = 0;
            int n2 = 0;
            while (salir == false)
            {
                Console.WriteLine("1.- Sumar");
                Console.WriteLine("2.- Resta");
                Console.WriteLine("3.- Multiplicacion");
                Console.WriteLine("4.- Division");
                Console.WriteLine("5.- Salir");

                Console.Write("Ingrese una opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el num 1: ");
                        n1 = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese el num 2: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la suma es: "+ matematicas.Suma(n1, n2));
                        break;
                    case 2:
                        Console.Write("Ingrese el num 1: ");
                        n1 = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese el num 2: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la resta es: " + matematicas.Resta(n1, n2));
                        break;
                    case 3:
                        Console.Write("Ingrese el num 1: ");
                        n1 = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese el num 2: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la multi es: " + matematicas.Multiplicacion(n1, n2));
                        break;
                    case 4:
                        Console.Write("Ingrese el num 1: ");
                        n1 = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese el num 2: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la div es: " + matematicas.Division(n1, n2));
                        break;
                    case 5:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción válida");
                        break;
                }
            }
        }
    }
}
