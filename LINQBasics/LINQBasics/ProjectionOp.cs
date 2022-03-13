using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQBasics
{
    public class ProjectionOp
    {
        public void basics()
        {
            List<int> numbers = new List<int>(){ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var numPlusOne = from num in numbers
                             select num + 1;

            foreach(int num in numPlusOne)
            {
                Console.WriteLine(num);
            }
        
        }

        public void basicsWithSingleProperty()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "Pen", 5.00, 5));
            products.Add(new Product(2, "NoteBook", 125.00, 7));
            products.Add(new Product(3, "Watch", 250.00, 0));
            products.Add(new Product(4, "Book", 150.00, 0));

            var ProductNames = from product in products
                               select product.name;

            foreach(string prodName in ProductNames)
            {
                Console.WriteLine(prodName);
            }
        }

        public void transformWithSelect()
        {
            List<int> numbers = new List<int>(){ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            List<string> strings = new List<string>(){ "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textNums = from num in numbers
                           select strings[num];

            foreach(string textNum in textNums)
            {
                Console.WriteLine(textNum);
            }
        }

        public void newTypeswithSelect()
        {
            List<string> words = new List<string>(){ "aPPLE", "BlUeBeRrY", "cHeRry" };

            var upperLowerWords = from word in words
                                  select new { Upper = word.ToUpper(), Lower = word.ToLower() };

            foreach (var transformedWord in upperLowerWords)
            {
                Console.WriteLine($"Uppercase: {transformedWord.Upper}, Lowercase: {transformedWord.Lower}");
            }
        }

        public void subsetOfProperties()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "Pen", 5.00, 5));
            products.Add(new Product(2, "NoteBook", 125.00, 7));
            products.Add(new Product(3, "Watch", 250.00, 0));
            products.Add(new Product(4, "Book", 150.00, 0));

            var ProductNameAndIDs = from product in products
                               select (product.id, product.name);

            foreach(var product in ProductNameAndIDs)
            {
                Console.WriteLine($"ID: {product.id}, Name: {product.name}");
            }
        }

        public void projectionFromMultipleInputs()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "Pen", 5.00, 5));
            products.Add(new Product(2, "NoteBook", 125.00, 7));
            products.Add(new Product(3, "Watch", 250.00, 0));
            products.Add(new Product(4, "Book", 150.00, 0));

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, "Tasnim", "Gazipur"));
            customers.Add(new Customer(2, "Sakib", "Dhaka"));
            customers.Add(new Customer(3, "Tamzid", "Rajshahi"));

            var selectedCustomersAndProducts = from customer in customers
                                               from product in products
                                               where customer.address == "Gazipur" && product.qty > 0
                                               select (customer.id, customer.name, product.name);

            foreach(var item in selectedCustomersAndProducts)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("------------------------------------------");
            var selectedCustomersAndProducts2 = from customer in customers
                                                where customer.address == "Gazipur"
                                               from product in products
                                               where product.qty > 0
                                               select (customer.id, customer.name, product.name);

            foreach (var item in selectedCustomersAndProducts2)
            {
                Console.WriteLine(item.ToString());
            }




        }
    }
}
