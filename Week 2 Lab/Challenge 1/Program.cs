using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0, productCount = 0;
            Product p = new Product();
            while (option != 4)
            {
                option = adminMenu();
                clearScreen();
                if (option == 1)
                {
                    p.viewProducts(productCount);
                }
                else if (option == 2)
                {
                    p.addProducts(ref productCount);
                }
                else if (option == 3)
                {
                    p.totalWorth(productCount);
                }
                clearScreen();
            }
            Console.WriteLine("Exiting...");
            Console.ReadKey();
        }

        static int adminMenu()
        {
            Console.WriteLine("1. View Products");
            Console.WriteLine("2. Add Products");
            Console.WriteLine("3. Total Store Worth");
            Console.WriteLine("4. Exit");
            return validInt(4, "Enter your option: ");
        }

        static void clearScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

                
        static int validInt(int limit, string message)
        {
            string option;
            bool found = false;
            while (!found)
            {
                Console.Write(message);
                option = Console.ReadLine();
                if (option.Length > 0 && option.Length < 5)
                {
                    for (int i = 0; i < option.Length; i++)
                    {
                        if (option[i] < 58 && option[i] > 47) // 48 -> 0 | 57 -> 9
                        {
                            if (i == option.Length - 1 && int.Parse(option) <= limit)
                            {
                                return int.Parse(option);
                            }
                            continue;
                        }
                        break;
                    }
                }
                Console.WriteLine("Invalid input!");
            }
            return -1;
        }        
    }

    class Product
    {
        string id;
        string name;
        int price;
        string category;
        string brand;
        string country;
        Product[] data = new Product[100];

        public void addProducts(ref int productCount)
        {
            Console.Clear();
            bool found = true;
            string name = "";
            Product obj = new Product();
            while (found)
            {
                found = false;
                Console.WriteLine("Enter Product name: ");
                name = Console.ReadLine();
                for (int i = 0; i < productCount; i++)
                {
                    if (name == data[i].name)
                    {
                        found = true;
                        break;
                    }
                }
            }
            obj.name = name;
            Console.Write("Enter product ID: ");
            obj.id = Console.ReadLine();
            obj.price = validInt(100, "Enter Price: ");
            Console.Write("Enter category: ");
            obj.category = Console.ReadLine();
            Console.Write("Enter brand: ");
            obj.brand = Console.ReadLine();
            Console.Write("Enter country: ");
            obj.country = Console.ReadLine();
            data[productCount] = obj;
            productCount++;
            Console.WriteLine("Product added succefully!");
        }


        // prints data of all the products
        public void viewProducts(int productCount)
        {
            Console.WriteLine("ID\tName\t\tPrice\t\tCategory\t\tBrand\t\tCountry");
            if (productCount == 0)
            {
                Console.WriteLine("No Records...");
            }
            else
            {
                for (int i = 0; i < productCount; i++)
                {
                    Console.WriteLine(data[i].id + "\t" + data[i].name + "\t\t" + data[i].price + "\t\t" + data[i].category + "\t\t\t" + data[i].brand + "\t\t" + data[i].country);
                }
            }
        }

        public void totalWorth(int productCount)
        {
            int sum = 0;
            for (int i =0; i < productCount; i++)
            {
                sum += data[i].price;
            }
            Console.WriteLine("Total Store Worth is: " + sum);
        }

        static int validInt(int limit, string message)
        {
            string option;
            bool found = false;
            while (!found)
            {
                Console.Write(message);
                option = Console.ReadLine();
                if (option.Length > 0 && option.Length < 5)
                {
                    for (int i = 0; i < option.Length; i++)
                    {
                        if (option[i] < 58 && option[i] > 47) // 48 -> 0 | 57 -> 9
                        {
                            if (i == option.Length - 1 && int.Parse(option) <= limit)
                            {
                                return int.Parse(option);
                            }
                            continue;
                        }
                        break;
                    }
                }
                Console.WriteLine("Invalid input!");
            }
            return -1;
        }
    }

}
