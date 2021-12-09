using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDemo
{
    public class Car
    {
         protected int wheels;
         protected internal int doors;

        public Car(int wheels)
        {
            this.wheels = wheels;
        }

    }
}
