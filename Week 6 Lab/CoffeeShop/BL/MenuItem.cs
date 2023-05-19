using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop
{
    public class MenuItem
    {
        public string name;
        public string type;
        public int price;

        // default constructor
        public MenuItem() { }

        // parameterized constructor
        public MenuItem(string name, string type, int price) 
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
    }
}