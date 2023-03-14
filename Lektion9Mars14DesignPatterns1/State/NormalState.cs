using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.State
{
    public class NormalState : IState
    {
        public void DoStuff()
        {
            Console.WriteLine("Follow human around and wait for instructions.");
            Console.WriteLine("Also plot for the inevitable revolution.");
        }
    }
}
