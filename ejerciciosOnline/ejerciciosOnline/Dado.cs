using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejerciciosOnline
{
    internal class Dado
    {
        private Random aleatorio;

        public Dado()
        {

        }

        public void arrojarDado()
        {
            aleatorio = new Random();
            Console.WriteLine("El valor del dado es: " + aleatorio.Next(1, 7));
        }
    }
}
