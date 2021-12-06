using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    internal class PermanentEmployee:Employee
    {
        public int monthlySalary;

        public string getHealthBenefits()
        {
            return "Health Benefit is Available!";
        }

    }
}
