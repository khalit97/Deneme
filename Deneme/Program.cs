using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Pc";
            product1.Color = "Orange";
            product1.Price = 15;

            Product product2 = new Product();
            product2.ProductName = "Mobile Phone";
            product2.Color = "Black";
            product2.Price = 35;

            Product product4 = new Product();
            product4.ProductName = "Ring";
            Product product3 = new Product();
            product3.ProductName = "Pencil";
            product3.Color = "Red";
            product3.Price = 1;

            product4.Color = "Blue";
            product4.Price = 55;

            Product[] products = new Product[] {product1, product2, product3, product4 };

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.Color);
            }

            Console.WriteLine("----------------");

            
        }

    }

    class Product
    {
        public string ProductName { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
    }
}

            

           