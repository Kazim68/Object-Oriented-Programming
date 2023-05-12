using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chapters = new List<String>() { "Chapter1", "Chapter2", "Chapter3"};
            Book book = new Book("ARK", 1000, chapters, 555, 2000);
            Console.WriteLine(book.getChapter(2));
            Console.WriteLine(book.getBookPrice());
            book.setBookPrice(2500);
            Console.WriteLine(book.getBookPrice());
            Console.ReadKey();
        }
    }
}
