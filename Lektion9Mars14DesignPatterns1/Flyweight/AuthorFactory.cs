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

        // The idea of the Flyweight pattern is to reuse objects that have already
        // been used. Hence, simply keep a dictionary containing the unique identifier
        // for the various objects as a key, and if one comes in with the same
        // identifier then get the already existing object. Otherwise, make a new one.
        // Notably, this makes it so if you change the values of one Author, in
        // this case, this value will be changed for all objects with that 
        // particular author. They're all using the same object, after all.
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
