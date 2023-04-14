using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menuselection();
        }

        static void Menuselection()
        {
            string[] products = new string[10];
            int[] quantity = new int[10];
            int[] price = new int[10];
            int option;
            int productCount = 0;
            string users_path = "users.txt", dataPath = "data.txt";
            loadArrays(dataPath, products, quantity, price, ref productCount);
            do
            {
                option = Menu();
                clearScreen();
                if (option == 1)
                {
                    if (Signin(users_path))
                    {
                        admin(dataPath, products, quantity, price, ref productCount);
                    }
                }
                else if (option == 2)
                {
                    Signup(users_path);
                }
            }
            while (option != 3);
            Console.WriteLine("Exiting...");
            Console.ReadKey();
        }

        static int Menu()
        {
            Console.WriteLine("1. Sign in");
            Console.WriteLine("2. Sign up");
            Console.WriteLine("3. Exit");
            return validInt(3, "Enter your option: ");
        }

        static bool Signin(string path)
        {
            Console.WriteLine("Enter username: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            bool check = Check(name, password, path);
            if (check)
            {
                Console.WriteLine("Welcome!");
                clearScreen();
                return true;
            }
            Console.WriteLine("Invalid credentials...");
            clearScreen();
            return false;
        }

        static void admin(string path, string[] products, int[] quantity, int[] price, ref int productCount)
        {
            int option = 0;
            while (option != 5)
            {
                option = adminMenu();
                if (option == 1)
                {
                    viewProducts(products, quantity, price, productCount);
                    clearScreen();
                }
                else if (option == 2)
                {
                    addProducts(path, products, quantity, price, ref productCount);
                }
                else if (option == 3)
                {
                    modifyProducts(path, products, quantity, price, productCount);
                }
                else if (option == 4)
                {
                    deleteProducts(path, products, quantity, price, ref productCount);
                }
            }
            clearScreen();
            Menuselection();
        }

        static int adminMenu()
        {
            Console.WriteLine("1. View Products");
            Console.WriteLine("2. Add Products");
            Console.WriteLine("3. Modify Products");
            Console.WriteLine("4. Delete Products");
            Console.WriteLine("5. Exit");
            return validInt(5, "Enter your option: ");
        }

        // prints data of all the products
        static void viewProducts(string[] products, int[] quantity, int[] price, int productCount)
        {
            Console.Clear();
            Console.WriteLine("Sr#\tProduct\t\tQuantity\tPrice");
            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine((i+1) + ".\t" + products[i] + "\t\t" + quantity[i] + "\t\t" + price[i]);
            }
        }

        // add a product in arrays 
        static void addProducts(string path, string[] products, int[] quantity, int[] price, ref int productCount)
        {
            Console.Clear();
            bool found = true;
            string name = "";
            while (found)
            {
                found = false;
                Console.WriteLine("Enter Product name: ");
                name = Console.ReadLine();
                for (int i =0; i < productCount; i++)
                {
                    if (name == products[i])
                    {
                        found = true;
                        break;
                    }
                }

            }
            products[productCount] = name;
            quantity[productCount] = validInt(100, "Enter Quantity: ");
            price[productCount] = validInt(100, "Enter Price: ");
            productCount++;
            writeArrays(path, products, quantity, price, productCount);
            clearScreen();
        }


        // make changes to products
        static void modifyProducts(string path, string[] products, int[] quantity, int[] price, int productCount)
        {
            viewProducts(products, quantity, price, productCount);
            Console.WriteLine((productCount + 1) + ".\tBack");
            int option = validInt(productCount + 1, "Enter your choice number: ");
            if (option != productCount+1)
            {
                quantity[option - 1] = validInt(100, "Enter new Quantity: ");
                price[option - 1] = validInt(100, "Enter new Price: ");
                writeArrays(path, products, quantity, price, productCount);
            }
            clearScreen();
        }

        // delete a product
        static void deleteProducts(string path, string[] products, int[] quantity, int[] price, ref int productCount)
        {
            viewProducts(products, quantity, price, productCount);
            Console.WriteLine((productCount + 1) + ".\tBack");
            int option = validInt(productCount + 1, "Enter your choice number: ");
            if (option != productCount + 1)
            {
                for (int i = option -1; i < productCount-1;i++)
                {
                    products[i] = products[i + 1];
                    quantity[i] = quantity[i + 1];
                    price[i] = price[i + 1];
                }
                productCount--;
                writeArrays(path, products, quantity, price, productCount);
                Console.WriteLine("Product deleted successfully!");
            }
            clearScreen();

        }

        // returns true if name and password match in sign in
        static bool Check(string name, string password, string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string data, username, pwd;
                while ((data = file.ReadLine()) != null)
                {
                    username = Field(data, 1);
                    pwd = Field(data, 2);
                    if (name == username && password == pwd)
                    {
                        file.Close();
                        return true;
                    }
                }
                file.Close();
            }
            return false;
        }

        static string Field(string data, int value)
        {
            int comma = 0;
            string field = "";
            for (int i =0; i < data.Length; i++)
            {
                if (data[i] == ',')
                {
                    comma++;
                }
                else if (comma == value-1)
                {
                    field += data[i];
                }
                else if (comma == value)
                { 
                    break;
                }
            }
            return field;
        }

        static void Signup(string path)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Upload(path, name, password);
            Console.WriteLine("Account created!");
        }

        // uploads user credentials data onto file
        static void Upload(string path, string name, string password)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + "," + password);
            file.Flush();
            file.Close();
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

        static void clearScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        static void loadArrays(string path, string[] products, int[] quantity, int[] price, ref int productCount)
        {
            StreamReader file = new StreamReader(path);
            string data;
            while ((data = file.ReadLine()) != null)
            {
                products[productCount] = Field(data, 1);
                quantity[productCount] = int.Parse(Field(data, 2));
                price[productCount] = int.Parse(Field(data, 3));
                productCount++;
            }
            file.Close();
        }

        static void writeArrays(string path, string[] products, int[] quantity, int[] price, int productCount)
        {
            if (File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path);
                for (int i = 0; i < productCount; i++)
                {
                    file.WriteLine(products[i] + "," + quantity[i] + "," + price[i]);
                }
                file.Flush();
                file.Close();
            }
        }
    }
}
