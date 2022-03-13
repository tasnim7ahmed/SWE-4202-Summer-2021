using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQBasics
{
    public class RestrictionOp
    {
        public void basics()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = from num in numbers
                          where num < 5
                          select num;

            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }

        public void basicsWithList()
        {
            List<int> numbers = new List<int>(){ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = from num in numbers
                          where num < 5
                          select num;

            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }

        public void filteringOnProperty()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "Pen", 5.00, 5));
            products.Add(new Product(2, "NoteBook", 125.00, 7));
            products.Add(new Product(3, "Watch", 250.00, 0));
            products.Add(new Product(4, "Book", 150.00, 0));

            var filteredProducts = from product in products
                                   where product.qty == 0 && product.price >= 200
                                   select product;

            Console.WriteLine("Filtered Product Names: ");
            foreach(Product product in filteredProducts)
            {
                Console.WriteLine(product.name);
            }


            // Extracting Only Names
            Console.WriteLine("After Extracting Only Product Names - ");
            var filteredProductNames = from product in products
                                   where product.qty == 0 && product.price >= 200
                                   select product.name;
            
            foreach (String prodName in filteredProductNames)
            {
                Console.WriteLine(prodName);
            }
        }

    }
}
