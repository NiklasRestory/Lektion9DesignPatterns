using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.CommandRemoteTask
{
    public class PreviousChannelCommand : IButtonCommand
    {
        private TV tv;
        public PreviousChannelCommand(TV tv)
        {
            this.tv = tv;
        }
        public void ExecuteButtonCommand()
        {
            if (tv.CurrentChannel > 0)
            {
                tv.CurrentChannel--;
            }
            else
            {
                tv.CurrentChannel = tv.HighestChannel;
            }
        }
    }
}
