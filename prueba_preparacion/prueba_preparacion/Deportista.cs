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

        public double Peso
        {
            get 
            { 
                return peso; 
            }
            set
            {
                peso = value;
            }
        }

        public int Minutos
        {
            get
            {
                return minutos;
            }
            set
            {
                minutos = value;
            }
        }
        public abstract double calcularCalorias();
    }

    class Futbolista : Deportista
    {
        public override double calcularCalorias()
        {
            double formula = 0.031 * Peso * 2.2 * Minutos;
            
           Console.WriteLine("Cantidad de calorias quemadas son: " + formula);
            return formula;
        }
    }

    class Peleador : Deportista
    {
        public override double calcularCalorias()
        {
            double formula = 0.049 * Peso * 2.2 * Minutos;
            Console.WriteLine("Cantidad de calorias quemadas son: " + formula);
            return formula;
        }
    }
}
