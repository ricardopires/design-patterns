using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    public class Motorcycle : IVehicle
    {
        public void GetCargo() => Console.Write("Getting cargo...");

        public void StartRoute()
        {
            GetCargo();
            Console.Write(" start route.");
        }
    }
}