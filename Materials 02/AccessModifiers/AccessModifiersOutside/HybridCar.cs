using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersOutside
{
    internal class HybridCar: AccessModifiersDemo.Car
    {

        string engine;
        string motor;
        public void printCar()
        {
            Console.WriteLine(this.doors);
        }

        public ElectricCar(int wheels) : base(wheels)
        {

        }

    }
}
