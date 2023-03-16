using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Iterator
{
    public class BookList
    {
        private List<Book> bookList = new List<Book>();

        public BookList(List<Book> bookList)
        {
            this.bookList = bookList;
        }
        public void Add(Book book)
        {
            bookList.Add(book);
        }
        // Each list we create should have a CreateIterator
        // function that creates an iterator for iterating over
        // that specific list.
        public IIterator<Book> CreateIterator()
        {
            return new BookIterator(bookList);
        }
    }
}
