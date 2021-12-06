using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.id = 1;
            emp1.age = 25;
            emp1.address = "IUT";
            emp1.designation = "Section Officer";
            emp1.name = "Generic Employee";

            Console.WriteLine("---Printing From Parent Class---");
            Console.WriteLine(emp1.getInfo());

            PermanentEmployee pemp1 = new PermanentEmployee();
            pemp1.id = 2;
            pemp1.age = 24;
            pemp1.address = "IUT";
            pemp1.designation = "Lecturer";
            pemp1.name = "Permanent Employee";

            Console.WriteLine("---Printing From Derived(Permanent Employee) Class---");
            Console.WriteLine(pemp1.getInfo());

            ContractualEmployee cemp1 = new ContractualEmployee();
            cemp1.id = 3;
            cemp1.age = 26;
            cemp1.address = "IUT";
            cemp1.designation = "Lecturer (Adjunct)";
            cemp1.name = "Contractual Employee";

            Console.WriteLine("---Printing From Derived(Contractual Employee) Class---");
            Console.WriteLine(cemp1.getInfo());

            Console.ReadKey();
        }
    }
}
