using System;
namespace DelegateAndEvents
{

    //Delegate is the Agreement/Contract between Publisher and Subscriber
    //Defines the Signature of the EventHandler method in the Subscriber

    public class DelegateExample
    {
        public delegate void MathFunc(int a, int b);

        public static void Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }


        public DelegateExample()
        {
            MathFunc mathfunc = Add;
            mathfunc(7, 2);
            Console.WriteLine("--- --- ---");
            mathfunc = Sub;
            mathfunc(7, 2);
            Console.WriteLine("--- --- ---");

            // MultiCasting Delegates
            OtherMathFunctions omf = new OtherMathFunctions();
            mathfunc += omf.Multiply;
            mathfunc(7, 2);
            Console.WriteLine("--- --- ---");

            mathfunc -= Sub;
            mathfunc += omf.Div;
            mathfunc(7, 2);
        }
    }

    public class OtherMathFunctions
    {
        public void Multiply(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public void Div(int a, int b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
    }
}
