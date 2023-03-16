using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Visitor
{
    public class VisitorDemonstration
    {
        public void Run()
        {
            PaperBook book = new PaperBook();
            AudioBook audioBook = new AudioBook();

            PlaceBookmarkVisitor visitor = new PlaceBookmarkVisitor();
            book.Accept(visitor);
            audioBook.Accept(visitor);

            Console.WriteLine("----");

            TurnPageVisitor turnPageVisitor = new TurnPageVisitor();
            book.Accept(turnPageVisitor);
            audioBook.Accept(turnPageVisitor);
        }
    }
}
