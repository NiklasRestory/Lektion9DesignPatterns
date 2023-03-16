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
        // Proxy as a design pattern is used to prevent the memory being overfilled with
        // objects we don't use. If we have a whole library, it is a waste to load in the
        // data of all the books if they're not going to be read. Instead, we create a
        // Proxy object, which contains the variables needed to FIND the actual object,
        // but we leave the object itself (Book book here) null until it is needed.
        public BookProxy(string title, BookDatabase bookDatabase)
        {
            Title = title;
            this.bookDatabase = bookDatabase;
        }

        // When we have actual need of the object, we call the Load function, that
        // actually loads the object from the database so we can look at the full
        // thing. Until that point, it would be a waste to actually have all that
        // in memory.
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
