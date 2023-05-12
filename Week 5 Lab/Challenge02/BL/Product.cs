using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02.BL
{
    internal class Product
    {
        public string name;
        public string category;
        public int price;
        public int quantity;
        public int threshold;

        // default constructor
        public Product() { }

        // parameterized constructor
        public Product(string name, string category, int price, int quantity, int threshold) 
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
            this.threshold = threshold;
        }

        // get the name of the product
        public string getName() { return name; }

        // get the category of product
        public string getCategory() { return this.category; }

        // get the price of product
        public int getPrice() { return this.price; }

        // get the quantity of product
        public int getQuantity() { return this.quantity; }

        // get the threshold of product
        public int getThreshold() { return this.threshold; }

        // product sold decreases the quantity by the number of sells
        public void sold(int sell) { this.quantity -= sell; }

        // returns the price of the product after tax
        public double getSalesTax()
        {
            if (this.category == "Grocery")
            {
                return this.price * 1.1F;
            }
            else if (this.category == "Fruit")
            {
                return this.price * 1.05F;
            }
            return this.price * 1.15F;
        }
    }
}
