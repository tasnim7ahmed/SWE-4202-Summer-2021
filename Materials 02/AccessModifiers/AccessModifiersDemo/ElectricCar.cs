using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDemo
{
    internal class ElectricCar:Car
    {
        string motor;

        void printInfo()
        {
            Console.WriteLine(this.doors);
        }
    }
}
