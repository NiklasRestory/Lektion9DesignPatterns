using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Iterator
{
    // Within the <> we determine through the iterator that we're
    // making the iterator of type Book.
    public class BookIterator : IIterator<Book>
    {
        private List<Book> bookList;
        private int index = 0;
        public BookIterator(List<Book> bookList)
        {
            this.bookList = bookList;
        }
        // There are three functions that the typical Iterator
        // Pattern interface makes us implement.
        // HasNext gives false if we've reached the end. As
        // long as HasNext gives true, we continue.
        public bool HasNext()
        {
            return index < bookList.Count;
        }
        // Current gives back the current object in the list.
        public Book Current()
        {
            return bookList[index];
        }
        // Next advances to the next object, however we do that.
        public void Next()
        {
            index++;
        }
    }
}
