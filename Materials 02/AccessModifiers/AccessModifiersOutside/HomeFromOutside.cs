using AccessModifiersDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersOutside
{
    internal class HomeFromOutside
    {
        public Car myCar;
        public void printCar()
        {
            Console.WriteLine(this.myCar.doors);
        }
    }
}
