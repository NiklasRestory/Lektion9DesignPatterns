using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lektion9Mars14DesignPatterns1.Prototype;

namespace Lektion9Mars14DesignPatterns1.State
{
    public class Robot
    {
        public IState State { get; set; }

        public Robot(IState state)
        {
            State = state;
        }

        public void DoThings()
        {
            State.DoStuff();
        }
    }
}
