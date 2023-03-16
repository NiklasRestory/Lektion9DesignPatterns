using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Visitor
{
    public interface IBookElement
    {
        // The visitor Design Pattern is comprised of elements and visitors.
        // The elements accept visitors, allowing them to do their own logic
        // upon these classes.
        void Accept(IVisitor visitor);
    }
}
