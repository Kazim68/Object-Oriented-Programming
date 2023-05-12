using Challenge02.UI;
using Challenge02.DL;
using Challenge02.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            do
            {
                option = Menu.loginMenu();
                if (option == "1")
                {
                    signIn();
                }
                else if (option == "2") 
                {
                    signUp();
                }
                else if (option != "0")
                {
                    Console.WriteLine("Invalid option");
                }
                Menu.transition();
            }
            while (option != "0");
        }

        // sign in 
        static void signIn()
        {
            MuserList.loadData();
            string name = Menu.takeInput("Name");
            string password = Menu.takeInput("Password");
            Muser user = null;
            if ((user = MuserList.signInCheck(name, password)) != null)
            {
                Menu.Welcome(user);
                if (user.role == "Customer")
                {
                    Customer customer = new Customer(user);
                    Customer(customer);
                }
                else
                {
                    admin();
                }
            }
            else
            {
                Menu.invalidMessage();
            }
        }

        // sign up
        static void signUp()
        {
            string name = Menu.takeInput("Name");
            string password = Menu.takeInput("password");
            string role = Menu.takeInput("role");
            Muser user = new Muser(name, password, role);
            MuserList.addUser(user);
            MuserList.saveData(user);
        }

        // customer menu and functionality
        static void Customer(Customer customer)
        {
            string option = "";
            do
            {
                option = Menu.CustomerMenu();
                Menu.transition();
                if (option == "1")
                {
                    // view products
                    Menu.ProductsLabel();
                    ProductList.viewProducts();
                }
                else if (option == "2")
                {
                    // buy products
                    Menu.ProductsLabel();
                    ProductList.viewProducts();
                    customer.addProduct(buyProduct());
                }
                else if (option == "3")
                {
                    // generate invoice
                    Menu.CustomerInvoice(customer);
                }
                Menu.transition();
            }
            while (option != "0");
        }

        // admin 
        static void admin()
        {
            string option = "";
            do
            {
                option = Menu.AdminMenu();
                Menu.transition();
                if (option == "1")
                {
                    // add products
                    ProductList.addProduct(makeProduct());
                }
                else if (option == "2")
                {
                    // view products
                    Menu.ProductsLabel();
                    ProductList.viewProducts();
                }
                else if (option == "3")
                {
                    // find product with highest price
                    Menu.ProductsLabel();
                    Menu.printProduct(ProductList.getProductWithHighestUnitPrice());
                }
                else if (option == "4")
                {
                    // view sales tax
                    Menu.salesTaxLabel();
                    ProductList.viewSalesTax();
                }
                else if (option == "5")
                {
                    // products to be ordered
                    Menu.ProductsLabel();
                    ProductList.productsToOrder();
                }
                Menu.transition();
            }
            while (option != "0");
        }

        // make a product
        static Product makeProduct()
        {
            string name = Menu.takeInput("Name");
            string category = Menu.takeInput("Category");
            int price = int.Parse(Menu.takeInput("Price"));
            int quantity = int.Parse(Menu.takeInput("Quantity"));
            int threshold = int.Parse(Menu.takeInput("Threshold"));
            Product product = new Product(name, category,price,quantity, threshold);
            return product;
        }

        // take product name from user to buy
        static Product buyProduct()
        {
            string name = Menu.takeInput("Name");
            Product product;
            if (( product = ProductList.isProduct(name)) != null)
            {
                product.sold(1);
                return product;
            }
            Menu.invalidMessage();
            buyProduct();
            return null;
        }
    }
}
