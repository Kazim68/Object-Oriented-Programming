using Challenge02.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02.UI
{
    internal class Menu
    {
        // login menu returns the chosen option
        public static string loginMenu()
        {
            Console.WriteLine("1.Sign in");
            Console.WriteLine("2.Sign up");
            Console.WriteLine("0.Exit");
            return Menu.takeInput("option");
        }

        // welcome message
        public static void Welcome(Muser user)
        {
            Console.WriteLine("Welcome {0}!", user.role);
            Menu.transition();
        }

        // invalid message
        public static void invalidMessage()
        {
            Console.WriteLine("Invalid data!");
        }

        // customer menu
        public static string CustomerMenu()
        {
            Console.WriteLine("1.View Products");
            Console.WriteLine("2.Buy Products");
            Console.WriteLine("3.Generate Invoice");
            Console.WriteLine("0.Back");
            return Menu.takeInput("option");
        }

        // admin menu
        public static string AdminMenu()
        {
            Console.WriteLine("1.Add Products");
            Console.WriteLine("2.View Products");
            Console.WriteLine("3.Find product with the highest unit price");
            Console.WriteLine("4.View sales tax of all products");
            Console.WriteLine("5.Products to be ordered");
            Console.WriteLine("0.Back");
            return Menu.takeInput("option");
        }

        // sales tax label
        public static void salesTaxLabel()
        {
            Console.WriteLine("Name\t\tSales Tax");
        }

        // print product with sales tax
        public static void printSalesTax(Product p)
        {
            Console.WriteLine("{0}\t\t{1}", p.getName(), p.getSalesTax());
        }

        // products label
        public static void ProductsLabel()
        {
            Console.WriteLine("Name\t\tCatergory\tPrice\tQuantity\tThreshold");
        }

        // print product data
        public static void printProduct(Product p)
        {
            Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}\t{4}", p.getName(), p.getCategory(), p.getPrice(), p.getQuantity(), p.getThreshold());
        }

        // customer invoice
        public static void CustomerInvoice(Customer customer)
        {
            Console.WriteLine("Name: " + customer.credentials.name);
            foreach (Product product in customer.getProducts())
            {
                Console.WriteLine("{0}\t\t{1}", product.name, product.price);
            }
            Console.WriteLine("Total bill is: " + customer.calculateBill());
        }


        // screen transition
        public static void transition()
        {
            Console.WriteLine("Press any key to proceed...");
            Console.ReadKey();
            Console.Clear();
        }

        // takes the input and returns a string 
        public static string takeInput(string message)
        {
            Console.Write("Enter {0}: ", message);
            return Console.ReadLine();
        }
    }
}
