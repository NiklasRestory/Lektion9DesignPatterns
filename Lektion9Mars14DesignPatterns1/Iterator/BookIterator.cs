using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Iterator
{
    public class BookIterator : IIterator<Book>
    {
        private List<Book> bookList;
        private int index = 0;
        public BookIterator(List<Book> bookList)
        {
            this.bookList = bookList;
        }
        public bool HasNext()
        {
            return index < bookList.Count;
        }
        public Book Current()
        {
            return bookList[index];
        }
        public void Next()
        {
            index++;
        }
    }
}
