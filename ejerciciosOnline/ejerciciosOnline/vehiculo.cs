using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejerciciosOnline
{
    abstract class vehiculo
    {
        public abstract void identificarVehiculo();

    }
    class auto : vehiculo
    {
        public override void identificarVehiculo()
        {
            Console.WriteLine("Hola soy un auto kuchau");
        }
    }
    class avion : vehiculo
    {
        public override void identificarVehiculo()
        {
            Console.WriteLine("Hola soy un aviom");
        }
    }
}
