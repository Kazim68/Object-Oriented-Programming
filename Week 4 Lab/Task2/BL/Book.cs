using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class Book
    {
        public string author;
        public int pages;
        public List<string> chapters;
        public int bookMark;
        public int price;

        // default constructor
        public Book()
        {

        }

        // parameterized constructor
        public Book(string author, int pages, List<string> chapters, int bookMark, int price)
        {
            this.author = author;
            this.pages = pages;
            this.chapters = chapters;
            this.bookMark = bookMark;
            this.price = price;
        }

        // geting chapter upon given the number of chapter
        public string getChapter(int chapterNumber)
        {
            return chapters[chapterNumber];
        }

        // get bookmark
        public int getBookmark()
        {
            return this.bookMark;
        }

        // set a bookmark
        public void setBookMark(int pageNo)
        {
            this.bookMark = pageNo;
        }

        // get book price
        public int getBookPrice()
        {
            return this.price;
        }

        // set a book price
        public void setBookPrice(int newPrice)
        {
            this.price = newPrice;
        }
    }
}
