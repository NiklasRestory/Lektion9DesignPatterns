using System.Security.Cryptography;

namespace Lektion9Mars14DesignPatterns1.Proxy
{
    public class Book
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public int Cost { get; set; }

        public Book(string title, int pageCount, string genre, string author, string language, int cost)
        {
            Title = title;
            PageCount = pageCount;
            Genre = genre;
            Author = author;
            Language = language;
            Cost = cost;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Title: " + Title + ", PageCount: " + PageCount + ", Genre: " + Genre + ", Author: " + Author + ", Language: " + Language + ", Cost: " + Cost);
        }
    }
}