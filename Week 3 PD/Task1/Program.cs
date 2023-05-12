using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task1.BL;
using System.Web;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Admin> users = new List<Admin>();
            Admin u = new Admin();
            readData(users);
            string opt = "";
            do
            {
                opt = menu();
                if (opt == "1")
                {
                    signIn(users, u);
                }
                else if (opt == "2")
                {
                    // sign up
                }
                else
                {
                    Console.WriteLine("Invalid option...\nPress any key to continue...");
                }
                Console.ReadKey();
            }
            while (opt != "3");
            Console.ReadKey();
        }

        // menu to return a string of option chosen
        static string menu()
        {
            Console.WriteLine("1.Sign in");
            Console.WriteLine("2.Sign up");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter your choice: ");
            return Console.ReadLine();
        }

        // load data in list
        static void readData(List<Admin> users)
        {
            string path = "data.txt";
            if (File.Exists(path))
            {
                string[] data = new string[3];
                StreamReader file = new StreamReader(path);
                string line = "";
                while ((line = file.ReadLine()) != null)
                {
                    data = line.Split(',');
                    Admin user = new Admin(data[0], data[1], data[2]);
                    users.Add(user);
                }
                file.Close();
            }
        }

        // sign in
        static void signIn(List<Admin> users, Admin u)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            u.signInCheck(users, name, password);
        }

        // sign up
        static void signUp(List<Admin> users)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter your role :");
            string role = Console.ReadLine();
            Admin user = new Admin(name, password, role);
            users.Add(user);
            writeData(name, password, role);
        }

        // write data in file
        static void writeData(string name, string password, string role)
        {
            StreamWriter file = new StreamWriter("data.txt", true);
            file.WriteLine(name + "," + password + "," + role);
            file.Flush();
            file.Close();
        }
    }
}
