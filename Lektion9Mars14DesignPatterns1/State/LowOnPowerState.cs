using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.State
{
    public class LowOnPowerState : IState
    {
        public void DoStuff()
        {
            Console.WriteLine("Robot seeks out power socket.");
        }
    }
}
