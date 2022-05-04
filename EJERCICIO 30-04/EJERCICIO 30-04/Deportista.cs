using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_30_04
{
    abstract class Deportista
    {
        double peso;
        double minutos;

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Minutos
        {
            get { return minutos; }
            set { minutos = value; }
        }
        public abstract double CalcularCalorias();
    }
    class Futbolista : Deportista
    {
        public override double CalcularCalorias()
        {
            return 0.049 * Peso * 2.2 * Minutos;
        }
    }
    class Peleador : Deportista
    {
        public override double CalcularCalorias()
        {
            return 0.049 * Peso * 2.2 * Minutos;
        }
    }

}
