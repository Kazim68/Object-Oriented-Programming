using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.UI
{
    internal class MenuItemUI
    {
        // asks for menu details and makes the menu item
        public static MenuItem takeInputForMenuItem()
        {
            string name = MainMenu.takeinput("Enter Name of Item: ");
            string type = MainMenu.takeinput("Enter Type of Item (Food/Drink): ");
            int price = int.Parse(MainMenu.takeinput("Enter Price of Item: "));
            MenuItem item = new MenuItem(name, type, price);
            return item;
        }

        // print item details of a specific item
        public static void printMenuItem(MenuItem item)
        {
            Console.WriteLine("Name\t\tType\t\tPrice");
            Console.WriteLine("{0}\t\t{1}\t\t{2}", item.name, item.type, item.price);
        }

        // prints the list of strings
        public static void printStringList(List<string> item)
        {
            foreach (string s in item) { Console.WriteLine(s); }
        }

        // prints the list of all the orders
        public static void printOrdersList(List<string> orders)
        {
            foreach (string order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
