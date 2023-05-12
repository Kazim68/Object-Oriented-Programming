using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    internal class Customer
    {
        public string name;
        public string address;
        public int contact;
        public List<Product> products = new List<Product>();

        // default constructor
        public Customer() { }

        // parameterized constructor
        public Customer(string name, string address, int contact)
        {
            this.name = name;
            this.address = address;
            this.contact = contact;
        }

        // get all products
        public List<Product> getAllProducts()
        {
            return this.products;
        }

        // add a product
        public void addProduct(Product p)
        {
            products.Add(p);
        }
    }
}
