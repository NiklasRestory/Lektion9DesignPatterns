using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Command
{
    public class CommandDemonstration
    {
        public void Run()
        {
            Village village = new Village();

            AddFood addFood = new AddFood(village);
            AddWood addWood = new AddWood(village);

            village.AddWorker(addFood);
            village.AddWorker(addWood);

            Console.WriteLine("There is " + village.Food + " food.");
            Console.WriteLine("There is " + village.Wood + " wood.");

            village.Day();

            Console.WriteLine("There is " + village.Food + " food.");
            Console.WriteLine("There is " + village.Wood + " wood.");
        }
    }
}
