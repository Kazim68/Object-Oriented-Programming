using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\Abdur rehman\\ARK\\Programming\\2nd Semester\\C# OOPS\\Week 2 Lab\\Challenge 2\\bin\\Debug\\userdata.txt";
            int option = 0;
            Credentials user = new Credentials();
            int count = 0;
            do
            {
                option = Menu();
                clearScreen();
                if (option == 1)
                {
                    user.Sign_In(count, path);
                }
                else if (option == 2)
                {
                    user.Sign_up(path, ref count);
                }
                clearScreen();
            }
            while (option != 3);
        }

        static int Menu()
        {
            Console.WriteLine("1. Sign in");
            Console.WriteLine("2. Sign up");
            Console.WriteLine("3. Exit");
            return validInt(3, "Enter your option: ");
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
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    class Credentials
    {
        public string name;
        public string password;
        public Credentials[] users = new Credentials[100];

        public void Sign_up(string path, ref int count)
        {
            Credentials obj = new Credentials();
            users[count] = obj;
            Console.Write("Enter name: ");
            users[count].name = Console.ReadLine();
            Console.Write("Enter password: ");
            users[count].password = Console.ReadLine();
            Upload(path, users[count].name, users[count].password);
            Console.WriteLine("Account created!");
            count++;
        }

        public void Sign_In(int count, string path)
        {
            Console.WriteLine("Enter username: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            if (Check(name, password, path))
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Invalid credentials...");
            }
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
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',')
                {
                    comma++;
                }
                else if (comma == value - 1)
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

        // uploads user credentials data onto file
        static void Upload(string path, string name, string password)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + "," + password);
            file.Flush();
            file.Close();
        }
    }
}