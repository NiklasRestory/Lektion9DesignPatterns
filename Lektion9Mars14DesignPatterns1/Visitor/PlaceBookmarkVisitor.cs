using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Visitor
{
    public class PlaceBookmarkVisitor : IVisitor
    {
        // Each visitor is meant to handle a specific task, which
        // may differ in implementation depending on the version.
        // Like, if we want to program for multiple kinds of
        // hardware at once, we might need a visitor that implements
        // the same function for the different kind of hardware separately.
        public void Visit(AudioBook audioBook)
        {
            Console.WriteLine("Put current page into memory.");
        }

        public void Visit(PaperBook paperBook)
        {
            Console.WriteLine("Place actual bookmark.");
        }
    }
}
