using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Iterator
{
    // The idea of the iterator pattern is to have a single structure for 
    // iteration that can be reused basically everywhere.
    // It currently takes a Generic, and the Generic type T can be replaced
    // with any type.
    public interface IIterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}
