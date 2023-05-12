using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02.BL
{
    internal class Customer
    {
        List<Product> products;
        public Muser credentials;

        // parameterized constructor
        public Customer(Muser credentials)
        {
            this.credentials = credentials;
            this.products = new List<Product>();
        }

        // add the product
        public void addProduct(Product product) { products.Add(product); }

        // get products 
        public List<Product> getProducts() { return products; }

        // returns the bill
        public double calculateBill()
        {
            double bill = 0D;
            foreach (Product product in products) 
            {
                bill += product.getSalesTax();
            }
            return bill;
        }
    }
}
