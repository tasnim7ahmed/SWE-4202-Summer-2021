using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQBasics
{
    public class OrderingOp
    {
        List<Product> products = new List<Product>();

        public OrderingOp()
        {
            products.Add(new Product(1, "Pen", 5.00, 5));
            products.Add(new Product(2, "NoteBook", 125.00, 7));
            products.Add(new Product(3, "Watch", 250.00, 0));
            products.Add(new Product(4, "Book", 150.00, 0));
            
        }

        public void basics()
        {
            var OrderedProducts = from product in products
                                  orderby product.price
                                  select product;
            foreach(Product product in OrderedProducts)
            {
                Console.WriteLine($"Name: {product.name}, Price: {product.price}");
            }

            Console.WriteLine("--- Descending Order --- ");

            var OrderedProductsDesc = from product in products
                                  orderby product.price descending
                                  select product;
            foreach (Product product in OrderedProductsDesc)
            {
                Console.WriteLine($"Name: {product.name}, Price: {product.price}");
            }
        }

        public void orderingByMultipleFields()
        {
            products.Add(new Product(5, "NoteBook3", 125.00, 7));
            products.Add(new Product(6, "NoteBook2", 125.00, 7));
            var OrderedProducts = from product in products
                                  orderby product.price, product.name
                                  select product;
            foreach (Product product in OrderedProducts)
            {
                Console.WriteLine($"Name: {product.name}, Price: {product.price}");
            }
        }
    }
}
