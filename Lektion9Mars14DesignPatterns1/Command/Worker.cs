using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Command
{
    public class Worker
    {
        ICommand command;

        public Worker(ICommand command)
        {
            this.command = command;
        }

        public void DoWork()
        {
            command.Execute();
        }
    }
}
