using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    internal class Employee
    {
        public int id;
        public string name;
        public int age;
        public string address;
        public string designation;


        public string getInfo()
        {
            return id.ToString() + "\t" + name + "\t" + age.ToString() + "\t" + address + "\t" + designation+"\n";
        }
    }
}
