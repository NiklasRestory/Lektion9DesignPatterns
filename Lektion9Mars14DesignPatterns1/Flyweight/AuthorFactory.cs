using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Flyweight
{
    public class AuthorFactory
    {
        public Dictionary<string, Author> authors = new Dictionary<string, Author>();
        public Author GetAuthor(string Name, int Age, int NumberOfPrisesWon)
        {
            if (authors.ContainsKey(Name))
            {
                Console.WriteLine(Name + " already exists.");
                return authors[Name];
            }
            Console.WriteLine(Name + " is new!");
            Author author = new Author(Name, Age, NumberOfPrisesWon);
            authors.Add(Name, author);
            return author;
        }
    }
}
