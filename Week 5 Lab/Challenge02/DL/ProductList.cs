using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge02.BL;
using Challenge02.UI;

namespace Challenge02.DL
{
    internal class ProductList
    {
        public static List<Product> products = new List<Product>();

        // add products
        public static void addProduct(Product product) { products.Add(product); }

        // get products
        public static List <Product> getProducts() { return products;}

        // product with highest unit price
        public static Product getProductWithHighestUnitPrice()
        {
            // we can sort the list and return the first index
            List<Product> sortedList = products.OrderByDescending(o => o.getPrice()).ToList();
            return sortedList[0];
        }

        // view products
        public static void viewProducts()
        {
            foreach (Product product in products) { Menu.printProduct(product); }
        }

        // view sales tax of all products
        public static void viewSalesTax()
        {
            foreach (Product product in products)
            {
                Menu.printSalesTax(product);
            }
        }

        // products to be ordered
        public static void productsToOrder()
        {
            foreach (Product product in products)
            {
                if (product.getQuantity() <= product.getThreshold())
                {
                    Menu.printProduct(product);
                }
            }
        }

        // returns the Product object if found 
        public static Product isProduct(string name)
        {
            foreach (Product product in products)
            {
                if (product.getName().Equals(name))
                {
                    return product;
                }
            }
            return null;
        }
    }
}
