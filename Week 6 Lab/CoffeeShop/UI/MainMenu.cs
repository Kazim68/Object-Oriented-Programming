using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.UI
{
    internal class MainMenu
    {
        // main menu 
        public static string printMenu()
        {
            Console.WriteLine("1.Add a Menu Item");
            Console.WriteLine("2.View the cheapest Item in the menu");
            Console.WriteLine("3.View the drink's menu");
            Console.WriteLine("4.View the food's menu");
            Console.WriteLine("5.Add order");
            Console.WriteLine("6.FulFill the order");
            Console.WriteLine("7.View the order's list");
            Console.WriteLine("8.Total Payable Amount");
            Console.WriteLine("9.Exit");
            return takeinput("Enter your choice: ");
        }

        // returns a string
        public static string takeinput(string message) 
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        // screen transition
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
