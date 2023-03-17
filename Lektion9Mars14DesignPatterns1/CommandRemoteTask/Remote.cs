using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.CommandRemoteTask
{
    public class Remote
    {
        TV tv;
        public Button button0;
        public Button button1;
        public Button button2;
        public Button button3;
        public Button button4;
        public Button button5;
        public Button button6;
        public Button button7;
        public Button button8;
        public Button button9;
        public Button buttonNext;
        public Button buttonPrevious;

        public Remote(TV tv)
        {
            this.tv = tv;
            button0 = new Button(new GoToChannelCommand(tv, 0));
            button1 = new Button(new GoToChannelCommand(tv, 1));
            button2 = new Button(new GoToChannelCommand(tv, 2));
            button3 = new Button(new GoToChannelCommand(tv, 3));
            button4 = new Button(new GoToChannelCommand(tv, 4));
            button5 = new Button(new GoToChannelCommand(tv, 5));
            button6 = new Button(new GoToChannelCommand(tv, 6));
            button7 = new Button(new GoToChannelCommand(tv, 7));
            button8 = new Button(new GoToChannelCommand(tv, 8));
            button9 = new Button(new GoToChannelCommand(tv, 9));
            buttonNext = new Button(new NextChannelCommand(tv));
            buttonPrevious = new Button(new PreviousChannelCommand(tv));
        }

        
    }
}
