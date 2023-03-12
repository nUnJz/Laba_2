using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Laba_2_3
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public Product(string name, string category)
        {
            Name = name;
            Category = category;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            List<Product> products = new List<Product>();

            using (StreamReader reader = new StreamReader("Продукти харчування.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    products.Add(new Product(words[0], words[1]));
                }
            }

            var groupedProducts = products.GroupBy(p => p.Category);

            foreach (var category in groupedProducts)
            {
                Console.WriteLine("{0}:", category.Key);
                
                foreach (var product in category)
                {
                    Console.WriteLine("{0}", product.Name, product.Category);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}