using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static void Task1and2()
        {
            Console.WriteLine("Hello World!");
            Console.Write("Hello World!");
            Console.Read();
        }

        static void Task3and6()
        {
            int var = 7;
            Console.WriteLine("Hello World!");
            Console.WriteLine(var);
            float value = 2.6f;
            Console.WriteLine("Float: ");
            Console.WriteLine(value);
            Console.Read();
        }

        static void Task4and5()
        {
            string text = "I am string";
            Console.WriteLine("String: ");
            Console.WriteLine(text);
            char value = 'a';
            Console.WriteLine("Char: ");
            Console.WriteLine(value);
            Console.Read();
        }

        static void Task7and8and9()
        {
            // string
            Console.Write(" Enter a String: ");
            string text = Console.ReadLine();
            Console.WriteLine(" Your String: " + text);

            // integer
            Console.Write("Enter an int: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(" Your Integer: " + num);

            // float
            Console.Write("Enter a float: ");
            float value = float.Parse(Console.ReadLine());
            Console.WriteLine(" Your Float: " + value);
            Console.Read();
        }

        static void Task10()
        {
            Console.Write("Enter length of square to calculate area: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Area is: " + (length * length));
            Console.Read();
        }

        static void Task11()
        {
            Console.Write("Enter your marks: ");
            int marks = int.Parse(Console.ReadLine());
            if (marks < 50)
            {
                Console.WriteLine("You failed!");
            }
            else
            {
                Console.WriteLine("You passed!");
            }
            Console.Read();
        }

        static void Task12()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Welcome Back!");
            }
            Console.Read();
        }

        static void Task13()
        {
            int sum = 0, num = 0;
            while (num != -1)
            {
                sum += num;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter any integer: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum: " + sum);
            Console.Read();
        }

        static void Task14()
        {
            int sum = 0, num = 0;
            do
            {
                sum += num;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter any integer: ");
                num = int.Parse(Console.ReadLine());
            }
            while (num != -1);
            Console.WriteLine("Sum: " + sum);
            Console.Read();
        }

        static void Task15()
        {
            int large = -99;
            int[] num = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter number: ");
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] > large)
                {
                    large = num[i];
                }
            }
            Console.WriteLine("Largest number: " + large);
            Console.Read();
        }

        static void Task16()
        {
            int age, toy;
            float price;
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter price of washing machine: ");
            price = float.Parse(Console.ReadLine());
            Console.Write("Enter Unit price of toys: ");
            toy = int.Parse(Console.ReadLine());
            float result = Savings(age, price, toy);
            if (result >= 0)
            {
                Console.WriteLine("Yes! " + result);
            }
            else
            {
                Console.WriteLine("No! " + (result));
            }
            Console.Read();
        }

        static float Savings(int age, float price, int toy)
        {
            int money = 10, saved = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    saved += money - 1;
                    money += 10;
                }
                else
                {
                    saved += toy;
                }
            }
            return saved - price;
        }
        static void Task17()
        {
            string path = "E:\\Abdur rehman\\ARK\\Programming\\2nd Semester\\C# OOPS\\Test\\data.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string data;
                while ((data = file.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("No file exists");
            }
            Console.Read();
        }

        static void Task18()
        {
            string path = "E:\\Abdur rehman\\ARK\\Programming\\2nd Semester\\C# OOPS\\Test\\data.txt";
            if (File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path);
                file.WriteLine("Welcome Back!");
                file.Flush();
                file.Close();
            }
            else
            {
                Console.WriteLine("No file exists");
            }
            Console.Read();
        }
    }
}
