using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Visitor
{
    public class PaperBook : IBookElement
    {
        // Each element simply takes the visitor and runs their function,
        // sending along themselves as they do. A different function will
        // be called depending on which type of object this is.
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
