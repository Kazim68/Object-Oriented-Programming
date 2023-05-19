using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.BL;
using CoffeeShop.DL;
using CoffeeShop.UI;

namespace CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MenuItemPath = "MenuItem.txt";
            if (MenuItemDL.loadMenuItemDataFromFile(MenuItemPath)) 
            {
                Console.WriteLine("Menu Item data loaded successfully!");
            }
            string option;
            do
            {
                option = MainMenu.printMenu();
                MainMenu.clearScreen();
                if (option == "1")
                {
                    // add a menu item
                    MenuItem item = MenuItemUI.takeInputForMenuItem();
                    MenuItemDL.addMenuItemInList(item);
                    MenuItemDL.storeItemInFile(item, MenuItemPath);
                }
                else if (option == "2")
                {
                    // view the cheapest item
                    MenuItemUI.printMenuItem(MenuItemDL.findCheapestItem());
                }
                else if (option == "3")
                {
                    // view drink's menu
                    MenuItemUI.printStringList(MenuItemDL.drinksMenuItems());
                }
                else if (option == "4")
                {
                    // view food's menu
                    MenuItemUI.printStringList(MenuItemDL.foodMenuItems());
                }
                else if (option == "5")
                {
                    // add order
                    string order = MainMenu.takeinput("Enter Name of item you want to order: ");
                    if (OrderDL.addOrder(order)) { Console.WriteLine("Order added!");}
                    else { Console.WriteLine("This item is currently unavailable!"); }
                }
                else if (option == "6")
                {
                    // fulfill the order
                    Console.WriteLine(OrderDL.fulfillOrder());
                }
                else if (option == "7")
                {
                    // view the order's list
                    MenuItemUI.printOrdersList(OrderDL.getOrdersList());
                }
                else if (option == "8")
                {
                    // total payable amount
                    Console.WriteLine("Total amount due: " + OrderDL.dueAmount());
                }
                MainMenu.clearScreen();
            }
            while (option != "9");
        }
    }
}
