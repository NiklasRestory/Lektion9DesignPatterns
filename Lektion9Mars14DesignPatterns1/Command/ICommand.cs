using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Command
{
    // The idea of the Command Pattern is that, when we have a button
    // or something else that can do various different things when
    // called, contain a Command object that implements the Command
    // interface within it. This command class then contains its
    // own function inside of its execute function.

    // The structure allows us to invent new commands by just adding
    // more command-classes that implement ICommand, and all the
    // existing code works fine.
    public interface ICommand
    {
        void Execute();
    }
}
