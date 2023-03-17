using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.CommandRemoteTask
{
    public class GoToChannelCommand : IButtonCommand
    {
        private TV tv;
        private int channelToGoTo;
        public GoToChannelCommand(TV tv, int channelToGoTo)
        {
            this.tv = tv;
            this.channelToGoTo = channelToGoTo;
        }
        public void ExecuteButtonCommand()
        {
            tv.CurrentChannel = channelToGoTo;
        }
    }
}
