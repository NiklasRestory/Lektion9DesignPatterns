using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Composite
{
    public class File : Component
    {
        public File(string name) : base(name)
        {
        }

        public override void PrintContents()
        {
            Console.WriteLine("I'm the file " + Name);
        }
    }
}
