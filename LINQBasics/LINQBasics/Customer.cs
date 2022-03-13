using System;
namespace LINQBasics
{
    public class Customer
    {
        public int id;
        public string name;
        public string address;

        public Customer(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
    }
}
