using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Flyweight
{
    public class Book
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
        public Author Author { get; set; }
        public Book(string title, int pageCount, string genre, Author author)
        {
            Title = title;
            PageCount = pageCount;
            Genre = genre;
            Author = author;
        }
    }
}
