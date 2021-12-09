using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDemo
{
    internal class Home
    {
        public Car myCar;

        public void printCar()
        {
            Console.WriteLine(this.myCar.doors);
        }
    }
}
