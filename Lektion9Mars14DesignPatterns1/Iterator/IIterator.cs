using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}
