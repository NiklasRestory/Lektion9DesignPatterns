using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Iterator
{
    public class IteratorDemonstration
    {
        public void Run()
        {
            BookList bookList = new BookList(new List<Book>());
            bookList.Add(new Book("Jake has a ladybug", "Jim"));
            bookList.Add(new Book("Flying through the air", "Jim"));
            bookList.Add(new Book("Diving into a rock", "Jim"));
            bookList.Add(new Book("Shrinking in space", "Jim"));

            IIterator<Book> iterator = bookList.CreateIterator();
            while(iterator.HasNext())
            {
                iterator.Current().PrintInfo();
                iterator.Next();
            }
        }
    }
}
