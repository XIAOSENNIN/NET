using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba_preparacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio1();
            ejercicio2();
            Console.ReadKey();
        }

        static void ejercicio1()
        {
            int cantidad_t;

            Console.Write("Ingrese cantidad de trabajadores: ");
            cantidad_t = int.Parse(Console.ReadLine());
            
            int[] rut = new int[cantidad_t];
            string[] nombre = new string[cantidad_t];
            int[] sueldo = new int[cantidad_t];
            int sumasueldo = 0;
            int prom = 0;

            for (int i = 0; i < cantidad_t; i++)
            {
                Console.Write("Ingrese rut del trabajador {0}: ",i+1);
                rut[i] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese nombre del trabajador {0}: ", i + 1);
                nombre[i] = Console.ReadLine();

                Console.Write("Ingrese sueldo del trabajador {0}: ", i + 1);
                sueldo[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
            }

            for (int i = 0; i < cantidad_t; i++)
            {
                Console.WriteLine("Nombre Trabajador: " + nombre[i] + "; Rut: " + rut[i] + "; Sueldo: "+sueldo[i]);
            }
            foreach (var item in sueldo)
            {
                sumasueldo += item;
            }

            Console.WriteLine("----------------------------------------");

            prom = sumasueldo / cantidad_t;

            Console.WriteLine("Promedio de sueldo de los trabajadores: " + prom);
            Console.WriteLine("----------------------------------------");

            int menor = sueldo[0];
            int mayor = sueldo[0];

            int indicemenor = 0;
            int indicemayor = 0;

            for (int i = 0; i < cantidad_t; i++)
            {
                Console.WriteLine("Rut: "+rut[i] + " || Nombre: " + nombre[i] + " || Sueldo: " + sueldo[i]);

                if (sueldo[i] < menor)
                {
                    menor = sueldo[i];
                    indicemenor = i;
                }
                if (sueldo[i] > mayor)
                {
                    mayor = sueldo[i];
                    indicemayor = i;
                }
            }
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Trabajador con el sueldo mayor: " + nombre[indicemayor] + " " +sueldo[indicemayor]);
            Console.WriteLine("Trabajador con el sueldo menor: " + nombre[indicemenor] + " " +sueldo[indicemenor]);
        }

        static void ejercicio2()
        {
            bool salir = false;
            double peso;
            int minutos;

            Futbolista fut = new Futbolista();
            Peleador pelea = new Peleador();


            while (salir == false)
            {
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1.- Futbolista");
                Console.WriteLine("2.- Peleador MMA");
                Console.WriteLine("3.- Salir");

                Console.Write("Eliga una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el peso: ");
                        peso = double.Parse(Console.ReadLine());

                        Console.Write("Ingrese los minutos: ");
                        minutos = int.Parse(Console.ReadLine());

                        fut.calcularCalorias(peso, minutos);



                        break;
                    case 2:
                        Console.Write("Ingrese el peso: ");
                        peso = double.Parse(Console.ReadLine());

                        Console.Write("Ingrese los minutos: ");
                        minutos = int.Parse(Console.ReadLine());

                        pelea.calcularCalorias(peso, minutos);

                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Escoje una opcion valida");
                        break;
                }
            }

        }

    }
}



