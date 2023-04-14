using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Task_1.BL;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> p = new List<Products>();
            List<string> menu = new List<string>();// { "1.View items", "2.Add items", "3.Delete items", "4.Exit" };
            int option = 0;
            string path = "data.txt";
            loadLists(p, path);
            while (true)
            {
                option = Menu(menu = new List<string>() { "1.View items", "2.Add items", "3.Delete items", "4.Exit" });
                Console.Clear();
                if (option == 1)
                {
                    viewItems(p);
                    transition();
                }
                else if (option == 2)
                {
                    p.Add(addItems(path));
                    transition();
                }
                else if (option == 3)
                {
                    deleteItems(p, path);
                    transition();
                }
                else
                {
                    break;
                }
            }
            Console.Clear();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

        static int Menu(List<string> options)
        {
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine(options[i]);
            }
            Console.WriteLine("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }

        static void viewItems(List<Products> p)
        {
            if (p.Count == 0)
            {
                Console.WriteLine("No records!");
            }
            else
            {
                Console.WriteLine("No\tName\t\tPrice\t\tQuantity\t\tCategory\t\tCountry");
                for (int i =0; i < p.Count; i++)
                {
                    Console.WriteLine((i+1) + "\t{0}\t\t{1}\t\t{2}\t\t\t{3}\t\t\t{4}", p[i].name, p[i].price, p[i].quantity, p[i].category, p[i].country);
                }
            }
        }

        static Products addItems(string path)
        {
            Products obj = new Products();
            Console.Write("Enter name of product: ");
            obj.name = Console.ReadLine();
            Console.Write("Enter Price: ");
            obj.price = int.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            obj.quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter category: ");
            obj.category = Console.ReadLine();
            Console.Write("Enter name of country: ");
            obj.country = Console.ReadLine();
            // upload data on a file
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine("{0},{1},{2},{3},{4}", obj.name, obj.price, obj.quantity, obj.category, obj.country);
            file.Flush();
            file.Close();
            return obj;
        }

        static void deleteItems(List<Products> p, string path)
        {
            viewItems(p);
            Console.Write("Enter product you want to delete: ");
            int option = int.Parse(Console.ReadLine());
            p.Remove(p[option - 1]);
            Console.WriteLine("Product deleted successfully!");
            writefiles(p, path);
        }

        static void writefiles(List<Products> p, string path)
        {
            StreamWriter file = new StreamWriter(path);
            Products obj = new Products();
            for (int i = 0; i < p.Count; i++)
            {
                obj = p[i];
                file.WriteLine("{0},{1},{2},{3},{4}", obj.name, obj.price, obj.quantity, obj.category, obj.country);
            }
            file.Flush();
            file.Close();
        }

        static void loadLists(List<Products> p, string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string data;
                while ((data = file.ReadLine()) != null)
                {
                    Products obj = new Products();
                    obj.name = Field(data, 1);
                    obj.price = int.Parse(Field(data, 2));
                    obj.quantity = int.Parse(Field(data, 3));
                    obj.category = Field(data, 4);
                    obj.country = Field(data, 5);
                    p.Add(obj);
                }
                file.Close();
            }
        }

        static string Field(string data, int comma)
        {
            int count = 1;
            string text = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',')
                {
                    count++;
                }
                else if (count == comma)
                {
                    text += data[i];
                }
                else if (count > comma)
                {
                    return text;
                }
            }
            return text;
        }

        static void transition()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
