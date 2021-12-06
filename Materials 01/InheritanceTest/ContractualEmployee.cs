using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    internal class ContractualEmployee:Employee
    {
        public int semesterwiseSalary;

        public string getTransportation()
        {
            return "Transportation is Available for " + this.name + "!\n";
        }
    }
}
