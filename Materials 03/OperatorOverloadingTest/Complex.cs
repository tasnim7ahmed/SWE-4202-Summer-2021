using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingTest
{
    internal class Complex
    {
        public int real;
        public int imaginary;

        public Complex()
        {

        }

        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static Complex operator +(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.real = a.real + b.real;
            c.imaginary = a.imaginary + b.imaginary;

            return c;
        }

        public override string ToString()
        {
            return "Real : " + real.ToString() + "\tImaginary : " + imaginary.ToString() + "\n";
        }


    }

    
}
