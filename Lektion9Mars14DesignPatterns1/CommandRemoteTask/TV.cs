using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.CommandRemoteTask
{
    public class TV
    {
        public int CurrentChannel { get; set; }
        public int HighestChannel { get; set; }

        public TV(int currentChannel, int numberOfChannels)
        {
            CurrentChannel = currentChannel;
            HighestChannel = numberOfChannels;
        }
    }
}
