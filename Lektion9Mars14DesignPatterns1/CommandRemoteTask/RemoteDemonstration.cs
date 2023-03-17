using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.CommandRemoteTask
{
    public class RemoteDemonstration
    {
        public void Run()
        {
            TV tv = new TV(0, 9);
            Remote remote = new Remote(tv);

            Console.WriteLine("Current channel: " + tv.CurrentChannel);

            remote.button7.PressButton();

            Console.WriteLine("Current channel: " + tv.CurrentChannel);

            remote.button3.PressButton();

            Console.WriteLine("Current channel: " + tv.CurrentChannel);

            remote.buttonPrevious.PressButton();

            Console.WriteLine("Current channel: " + tv.CurrentChannel);

            remote.buttonNext.PressButton();

            Console.WriteLine("Current channel: " + tv.CurrentChannel);

            remote.button9.PressButton();
            Console.WriteLine("Current channel: " + tv.CurrentChannel);
            remote.buttonNext.PressButton();
            Console.WriteLine("Current channel: " + tv.CurrentChannel);
            remote.buttonPrevious.PressButton();
            Console.WriteLine("Current channel: " + tv.CurrentChannel);
        }
    }
}
