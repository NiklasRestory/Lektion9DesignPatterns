using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Command
{
    public class AddFood : ICommand
    {
        Village village;
        public AddFood(Village village)
        {
            this.village = village;
        }

        public void Execute()
        {
            Console.WriteLine("Worker adds food!");
            village.Food += 1;
        }
    }
}
