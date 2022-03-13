using System;
namespace LINQBasics
{
    public class Product
    {
        public int id;
        public string name;
        public double price;
        public int qty;

        public Product(int id, string name, double price, int qty)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
        }
    }
}
