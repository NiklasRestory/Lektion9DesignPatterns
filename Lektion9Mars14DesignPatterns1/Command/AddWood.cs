using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Command
{
    public class AddWood : ICommand
    {
        Village village;
        public AddWood(Village village)
        {
            this.village = village;
        }

        public void Execute()
        {
            Console.WriteLine("Worker adds wood!");
            village.Wood += 1;
        }
    }
}
