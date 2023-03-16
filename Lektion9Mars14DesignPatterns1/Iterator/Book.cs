using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Iterator
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Title: " + Title + ", Author: " + Author);
        }
    }
}
