using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    internal class Product
    {
        public string name;
        public string category;
        public int price;

        // default constructor
        public Product() { }

        // parameterized constructor
        public Product(string name, string category, int price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }

        // calculate tax
        public float calculateTax()
        {
            return this.price * 1.1F;
        }
    }
}
