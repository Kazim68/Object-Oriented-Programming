using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Admin> users = new List<Admin>();
            List<Brand> brands = new List<Brand>();
            string option, login;
            do
            {
                login = loginMenu();
                if (login == "1")
                {
                    // sign in
                    if (signIn(users))
                    {
                        do
                        {
                            option = mainMenu();
                            transition();
                            if (option == "1")
                            {
                                brands.Add(addBrand());
                            }
                            else if (option == "2")
                            {
                                viewBrand(brands);
                                if (brands.Count > 0)
                                {
                                    viewSpecificBrand(brands);
                                }
                            }
                            else if (option == "3")
                            {
                                modifyBrand(brands);
                            }
                            else if (option == "4")
                            {
                                deleteBrand(brands);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input!");
                            }
                            transition();
                        }
                        while (option != "5");
                    }
                    else
                    {
                        Console.WriteLine("Invalid credentials...");
                    }
                    transition();
                }
                else if (login == "2")
                {
                    users.Add(signUp());
                }
                transition();  
            }
            while (login != "3");
            Console.ReadKey();
        }

        // login Screen
        static string loginMenu()
        {
            Console.WriteLine("1.Sign In");
            Console.WriteLine("2.Sign Up");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter your choice: ");
            return Console.ReadLine();
        }

        // sign up
        static Admin signUp()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string pass = Console.ReadLine();
            Admin user = new Admin(name, pass);
            return user;
        }

        // sign in
        static bool signIn(List<Admin> users)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string pass = Console.ReadLine();
            foreach (Admin admin in users)
            {
                if (admin.name == name && admin.password == pass)
                {
                    return true;
                }
            }
            return false;
        }

        // main menu return a string argument indicating chosen option
        static string mainMenu()
        {
            Console.WriteLine("1.Add Brand");
            Console.WriteLine("2.View Brand");
            Console.WriteLine("3.Modify Brand");
            Console.WriteLine("4.Delete Brand");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter your choice: ");
            return Console.ReadLine();
        }

        // add a brand
        static Brand addBrand()
        {
            Console.WriteLine("Enter name of Brand: ");
            string name = Console.ReadLine();
            List<Product> products = takeProducts();
            Brand brand = new Brand(name, products);
            return brand;
        }

        // takes the products of brands and returns them as a list
        static List<Product> takeProducts()
        {
            List<Product> products = new List<Product>();
            string option = "";
            do
            {
                option = productMenu();
                if (option == "1")
                {
                    Console.WriteLine("Enter name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Price: ");
                    int price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    Product p = new Product(name, price, quantity);
                    products.Add(p);
                }
                else if (option != "2")
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
            while (option != "2");
            return products;
        }

        // products menu while making a new brand
        static string productMenu()
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Done");
            Console.WriteLine("Enter your choice: ");
            return Console.ReadLine();
        }

        // print brand data
        static void viewBrand(List<Brand> brands)
        {
            if (brands.Count > 0)
            {
                Console.WriteLine("Sr#\tName\t\tSales");
                for (int i = 0; i < brands.Count; i++)
                {
                    Console.WriteLine("{0}\t{1}\t\t{2}", i + 1, brands[i].name, brands[i].sales);
                }
                Console.WriteLine("{0}.Back", 0);
            }
            else
            {
                Console.WriteLine("No Brands Data.");
            }
        }

        // see credentials of a brand
        static void viewSpecificBrand(List<Brand> brands)
        {
            int option = 0;
            do
            {
                option = whichBrand(brands);
                if (option > 0 && option < brands.Count + 1)
                {
                    printBrandData(brands, option-1);
                    transition();
                }
            }
            while (option != 0);
        }

        // takes option for which brand to see
        static int whichBrand(List<Brand> brands)
        {
            Console.WriteLine("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }

        // prints data of a specific brand
        static void printBrandData(List<Brand> brands, int i)
        {
            Console.WriteLine("Brand: " + brands[i].name);
            Console.WriteLine("Name\t\tPrice\tQuantity");
            foreach (Product product in brands[i].products)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}", product.name, product.price, product.quantity);
            }
        }

        // modify brands
        static void modifyBrand(List<Brand> brands)
        {
            int option = 0;
            do
            {
                viewBrand(brands);
                option = whichBrand(brands);
                if (option > 0 && option < brands.Count + 1)
                {
                    printBrandData(brands, option - 1);
                    int opt = 0;
                    do
                    {
                        opt = modifyMenu();
                        if (opt == 1)
                        {
                            // change name
                            Console.WriteLine("Enter name: ");
                            brands[option - 1].name = Console.ReadLine();
                        }
                        else if (opt == 2)
                        {
                            // change sales
                            Console.WriteLine("Enter sales: ");
                            brands[option - 1].sales = int.Parse(Console.ReadLine());
                        }
                    }
                    while (opt != 3);
                }
                transition();
            }
            while (option != 0);
        }

        // modify menu 
        static int modifyMenu()
        {
            Console.WriteLine("1.Change Name");
            Console.WriteLine("2.Change Sales");
            Console.WriteLine("3.Back");
            Console.WriteLine("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }

        // delete brand
        static void deleteBrand(List<Brand> brands)
        {
            int option = 0;
            do
            {
                viewBrand(brands);
                option = whichBrand(brands);
                if (option > 0 && option < option + 1)
                {
                    Console.WriteLine("Are you sure you want to delete? (Y/N): ");
                    string opt = Console.ReadLine();
                    if (opt == "Y" || opt == "y")
                    {
                        brands.RemoveAt(option - 1);
                    }
                }
                transition();
            }
            while (option != 0);
        }

        // change screen transition
        static void transition()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
