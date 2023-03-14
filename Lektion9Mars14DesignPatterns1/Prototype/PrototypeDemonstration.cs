using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Prototype
{
    public class PrototypeDemonstration
    {
        public void Run()
        {
            Human patrick = new Human("Patrick", 45);
            Robot robot = new Robot("IA2", 100, "Eat Cheese", patrick);

            Robot robotClone = (Robot)robot.Clone();
        }
    }
}
