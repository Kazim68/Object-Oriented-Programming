using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.BL;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Customer", "Address", 666);
            Product mango = new Product("Mango", "Fruits", 10);
            Product chair = new Product("Chair", "Furniture", 50);
            c.addProduct(mango);
            c.addProduct(chair);
            foreach (Product p in c.getAllProducts())
            {
                Console.WriteLine(p.name + ", " + p.price + ", " + p.calculateTax());
            }
            Console.ReadKey();
        }
    }
}
