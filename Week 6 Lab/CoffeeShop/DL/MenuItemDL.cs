using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DL
{
    internal class MenuItemDL
    {
        public static List<MenuItem> Items = new List<MenuItem>();

        // add new menu item in list
        public static void addMenuItemInList(MenuItem item)
        {
            Items.Add(item);
        }

        // returns true if item found in list
        public static bool inMenuItemList(string name)
        {
            foreach (MenuItem item in Items) 
            {
                if (item.name == name) { return true; }
            }
            return false;
        }

        // returns the menu item obj if found in list
        public static MenuItem getItemFromList(string name) 
        {
            foreach (MenuItem item in Items) 
            {
                if (item.name == name) { return item; }
            }
            return null;
        }

        // finds the cheapest item and returns it
        public static MenuItem findCheapestItem()
        {
            int low = 9999;
            MenuItem item = null;
            foreach (MenuItem i in Items)
            {
                if (i.price < low)
                {
                    low = i.price;
                    item = i;
                }
            }
            return item;
        }

        // returns a list of drinks in the items list
        public static List<string> drinksMenuItems()
        {
            List<string> drinks = new List<string>();
            foreach (MenuItem item in Items) 
            {
                if (item.type.ToLower() == "drink") { drinks.Add(item.name); }
            }
            return drinks;
        }

        // returns a list of food in the items list
        public static List<string> foodMenuItems()
        {
            List<string> food = new List<string>();
            foreach (MenuItem item in Items)
            {
                if (item.type.ToLower() == "food") { food.Add(item.name); }
            }
            return food;
        }

        // store item in file
        public static void storeItemInFile(MenuItem item, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.Write(item.name + "," + item.type + "," + item.price);
            file.Flush();
            file.Close();
        }

        // load  menu item data from file
        public static bool loadMenuItemDataFromFile(string path)
        {
            if (File.Exists(path)) 
            {
                StreamReader file = new StreamReader(path);
                string line;
                while ((line = file.ReadLine()) != null) 
                {
                    string[] data = line.Split(',');
                    MenuItem item = new MenuItem(data[0], data[1], int.Parse(data[2]));
                    addMenuItemInList(item);
                    return true;
                }
            }
            return false;
        }
    }
}
