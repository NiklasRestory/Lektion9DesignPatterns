using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.CommandRemoteTask
{
    public class NextChannelCommand : IButtonCommand
    {
        private TV tv;
        public NextChannelCommand(TV tv)
        {
            this.tv = tv;
        }
        public void ExecuteButtonCommand()
        {
            if (tv.CurrentChannel < tv.HighestChannel)
            {
                tv.CurrentChannel++;
            }
            else
            {
                tv.CurrentChannel = 0;
            }
        }
    }
}
