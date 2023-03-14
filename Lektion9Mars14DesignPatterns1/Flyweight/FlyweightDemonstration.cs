using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Flyweight
{
    public class FlyweightDemonstration
    {
        public void Run()
        {
            AuthorFactory authorFactory = new AuthorFactory();

            Book jakesDiary = new Book("Jake's Diary", 33, "Fantasy", authorFactory.GetAuthor("Jake", 22, 2));
            Book jakesSecondDiary = new Book("Jake's Second Diary", 45234, "Mystery", authorFactory.GetAuthor("Jake", 22, 2));
            Book lordOfTheRings = new Book("Lord of the Wings", 432, "Fantasy", authorFactory.GetAuthor("J.R.R. Tolkien", 100, 99));

            Console.WriteLine("There are " + authorFactory.authors.Count + " authors in the database now.");
        }
    }
}
