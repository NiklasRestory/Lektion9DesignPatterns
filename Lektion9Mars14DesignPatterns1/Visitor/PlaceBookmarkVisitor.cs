using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Visitor
{
    public class PlaceBookmarkVisitor : IVisitor
    {
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
