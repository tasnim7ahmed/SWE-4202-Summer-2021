using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQBasics
{
    public class PartitionOp
    {
        List<Product> products = new List<Product>();

        public PartitionOp()
        {
            products.Add(new Product(1, "Pen", 5.00, 5));
            products.Add(new Product(2, "NoteBook", 125.00, 7));
            products.Add(new Product(3, "Watch", 250.00, 0));
            products.Add(new Product(4, "Book", 150.00, 0));
        }
        public void takeAndSkipPartition()
        {
            var ProductNames = from product in products
                               select product.name;

            foreach(string prodName in ProductNames)
            {
                Console.WriteLine(prodName);
            }

            Console.WriteLine("--- First Two ---");

            var ProductNames2 = (from product in products
                               select product.name).Take(2);

            foreach (string prodName in ProductNames2)
            {
                Console.WriteLine(prodName);
            }

            Console.WriteLine("--- Except First Two ---");

            var ProductNames3 = (from product in products
                                 select product.name).Skip(2);

            foreach (string prodName in ProductNames3)
            {
                Console.WriteLine(prodName);
            }
        }

        public void takeWhileAndSkipWhile()
        {
            var ProductsNotEmpty = (from product in products
                                    select product).TakeWhile(product => product.qty>0 );
            Console.WriteLine("--- Products that are in stock ---");
            foreach(Product product in ProductsNotEmpty)
            {
                Console.WriteLine($"Name: {product.name}, Quantity: {product.qty}");
            }

            var ProductsEmpty = (from product in products
                                    select product).SkipWhile(product => product.qty > 0);
            Console.WriteLine("--- Products that are not in stock ---");
            foreach (Product product in ProductsEmpty)
            {
                Console.WriteLine($"Name: {product.name}, Quantity: {product.qty}");
            }
        }

        
    }
}
