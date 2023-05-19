using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DL
{
    internal class OrderDL
    {
        public static List<string> orders = new List<string>();

        // add an order
        public static bool addOrder(string order)
        {
            if (MenuItemDL.inMenuItemList(order))
            {
                orders.Add(order);
                return true;
            }
            return false;
        }

        // fulfill order
        public static string fulfillOrder()
        {
            if (orders.Count == 0)
            {
                return "All orders have been fulfilled!";
            }
            string item = orders[0];
            orders.RemoveAt(0);
            return "The " + item + " is ready!";
        }

        // returns the list of orders
        public static List<string> getOrdersList()
        {
            return orders;
        }

        // returns the bill
        public static int dueAmount()
        {
            int amount = 0;
            if (orders.Count > 0)
            {
                MenuItem item;
                foreach (string order in orders)
                {
                    if ((item = MenuItemDL.getItemFromList(order)) != null)
                    {
                        amount += item.price;
                    }
                }
            }
            return amount;
        }
    } 
}
