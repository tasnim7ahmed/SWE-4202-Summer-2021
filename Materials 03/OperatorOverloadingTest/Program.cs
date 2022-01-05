using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account savings = new Account("4018-617387-314", "Tasnim", "Rajshahi", 1000);
            Console.WriteLine("----------SAVINGS A/C--------\n");
            Console.WriteLine(savings.ToString());
            Console.WriteLine("------------------\n");

            System.Threading.Thread.Sleep(1000);

            Account current = new Account("2802-617387-300", "Sakib", "Dhaka", 2500);
            Console.WriteLine("----------CURRENT A/C--------\n");
            Console.WriteLine(current.ToString());
            Console.WriteLine("------------------\n");

            Console.WriteLine("Difference : "+current.ac_opening.Subtract(savings.ac_opening).TotalMilliseconds.ToString()+"\n");

            Account merged = savings + current;
            Console.WriteLine("----------MERGED A/C--------\n");
            Console.WriteLine(merged.ToString());
            Console.WriteLine("------------------\n");

            Complex a = new Complex(2, 3);
            Console.WriteLine("a - " + a.ToString());
            Complex b = new Complex(4, 5);
            Console.WriteLine("b - " + b.ToString());
            Complex c = a + b;
            Console.WriteLine("c - " + c.ToString());
            

            Console.ReadKey();
        }
    }
}
