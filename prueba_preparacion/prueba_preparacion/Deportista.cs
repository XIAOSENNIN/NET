using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba_preparacion
{
    abstract class Deportista
    {
        private double peso;
        private int minutos;

        public abstract double calcularCalorias(double peso, int minutos);
    }

    class Futbolista : Deportista
    {
        public override double calcularCalorias(double peso, int minutos)
        {
            double formula = 0.031 * peso * 2.2 * minutos;
            
           Console.WriteLine("Cantidad de calorias: " + formula);
            return formula;
        }
    }

    class Peleador : Deportista
    {
        public override double calcularCalorias(double peso, int minutos)
        {
            double formula = 0.049 * peso * 2.2 * minutos;
            Console.WriteLine("Cantidad de calorias: " + formula);
            return formula;
        }
    }
}
