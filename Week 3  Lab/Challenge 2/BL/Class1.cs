using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2.BL
{
    internal class Product
    {
        public string name;
        public char category;
        public int price;
        public int quantity;
        public int threshold;

        // default constructor
        public Product()
        {
            name = "";
            category = 'o';
            price = 0;
            quantity = 0;
            threshold = 0;
        }

        // parameterized constructor
        public Product(string n, char c, int p, int q, int t)
        {
            name = n;
            category = c;
            price = p;
            quantity = q;
            threshold = t;
        }

        // copy constructor
        public Product(Product p)
        {
            name = p.name;
            category = p.category;
            price = p.price;
            quantity = p.quantity;
            threshold = p.threshold;
        }

        // view products
        public void viewProducts(List<Product> p)
        {
            Console.WriteLine("Sr#\tName\t\tCategory\t\tPrice\t\tQuantity\t\tThreshold");
            int c = 1;
            foreach (Product i in p)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}\t\t\t{3}\t\t{4}\t\t\t{5}", c, i.name, i.category, i.price, i.quantity, i.threshold);
                c++;
            }
        }

        // add product
        public Product addProduct()
        {
            Console.Write("Enter name of Product: ");
            string pname = Console.ReadLine();
            Console.Write("Enter category. (G) for Groceries, (F) for Fresh Fruit and (O) for Other: ");
            char pcategory = validCategory(Console.ReadLine());
            int pprice = validInt("Enter price: ", 100);
            int pquantity = validInt("Enter Quantity: ", 100);
            int pthreshold = validInt("Enter Threshold: ", 100);
            Product p = new Product(pname, pcategory, pprice, pquantity, pthreshold);
            Console.WriteLine("Product added successfully!");
            return p;
        }

        // product with hightest price
        public void highestPrice(List<Product> p)
        {
            int high = 0;
            Product temp = null;
            foreach (Product product in p)
            {
                if (product.price > high)
                {
                    high = product.price;
                    temp = product;
                }
            }
            Console.WriteLine("Name\t\tPrice\t\tCategpry");
            Console.WriteLine("{0}\t\t{1}\t\t{2}", temp.name, temp.price, temp.category);
        }

        // view sales tax of all products
        public void viewTax(List<Product> product)
        {
            Console.WriteLine("Sr#\tName\t\tTax");
            int c = 1;
            foreach (Product p in product)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}", c, p.name, tax(p.price, p.category));
                c++;
            }
        }

        // calculate sales tax
        public double tax(int pri, char ctg)
        {
            if (ctg == 'G')
            {
                return 1.1 * pri;
            }
            else if (ctg == 'F')
            {
                return 1.05 * pri;
            }
            return 1.15 * pri;
        }

        // products to be ordered
        public void productsToOrder(List<Product> product)
        {
            Console.WriteLine("Sr#\tName\t\tOrder");
            int c = 1;
            foreach (Product p in product)
            {
                if (p.quantity < p.threshold)
                {
                    Console.WriteLine("{0}\t{1}\t\t{2}", c, p.name, "Yes");
                    c++;
                }
            }
        }

        // taking valid char input 
        public char validCategory(string text)
        {
            if (text == "G" || text == "g")
            {
                return 'G';
            }
            else if (text == "F" || text == "f")
            {
                return 'F';
            }
            return 'O';
        }

        // taking valid int input
        public int validInt(string message, int limit)
        {
        string text = "";
            Console.Write(message);
            text = Console.ReadLine();
            foreach (char letter in text)
            {
                if (letter < 48 || letter > 57)
                {
                    Console.WriteLine("Invalid Input!");
                    validInt(message, limit);
                }
            }
            if (int.Parse(text) < 0 || int.Parse(text) > limit)
            {
                Console.WriteLine("Invalid Input!");
                validInt(message, limit);
            }
            return int.Parse(text);
        }
    }
}
