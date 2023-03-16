using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Proxy
{
    public class BookProxy
    {
        BookDatabase bookDatabase;
        public string Title { get; set; }
        private Book book;
        public BookProxy(string title, BookDatabase bookDatabase)
        {
            Title = title;
            this.bookDatabase = bookDatabase;
        }

        public void Load()
        {
            if (book == null)
            {
                Console.WriteLine("Loading " + Title);
                book = bookDatabase.GetBookByTitle(Title);
            }
        }

        public int PageCount { 
            get
            {
                Load();
                return book.PageCount;
            }
            set
            {
                Load();
                book.PageCount = value;
            }
        }

        public void PrintInfo()
        {
            Load();
            book.PrintInfo();
        }
    }
}
