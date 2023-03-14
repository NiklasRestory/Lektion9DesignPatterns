using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.State
{
    public class StateDemonstration
    {
        public void Run()
        {
            Robot robot = new Robot(new NormalState());

            robot.DoThings();
            Console.WriteLine("-----");

            robot.State = new LowOnPowerState();

            robot.DoThings();
            Console.WriteLine("-----");

            robot.State = new WorkState();

            robot.DoThings();
        }
    }
}
