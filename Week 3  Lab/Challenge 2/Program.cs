using Challenge_2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            List<string> options = new List<string>() {"1.Add Product", "2.View all Products", "3.Product with highest Price", "4.View sales tax", "5.Products to be ordered", "6.Exit"};
            Product p = new Product();
            string option = "";
            do
            {
                option = Menu(options);
                transition();
                if (option == "1")
                {
                    products.Add(p.addProduct());
                }
                else if (option == "2")
                {
                    p.viewProducts(products);
                }
                else if (option == "3")
                {
                    p.highestPrice(products);
                }
                else if (option == "4")
                {
                    p.viewTax(products);
                }
                else if (option == "5")
                {
                    p.productsToOrder(products);
                }
                else if (option == "6")
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid choice!");
                }
                transition();
            }
            while (true);
            Console.WriteLine("Exiting...");
            Console.ReadKey();
        }

        // prints menu
        static string Menu(List<string> options)
        {
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        // screen transition
        static void transition()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
