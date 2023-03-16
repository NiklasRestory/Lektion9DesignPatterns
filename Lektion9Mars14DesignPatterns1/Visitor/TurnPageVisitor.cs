using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Visitor
{
    public class TurnPageVisitor : IVisitor
    {
        public void Visit(AudioBook audioBook)
        {
            Console.WriteLine("Play turn-page sound.");
        }

        public void Visit(PaperBook paperBook)
        {
            Console.WriteLine("Turn the page.");
        }
    }
}
