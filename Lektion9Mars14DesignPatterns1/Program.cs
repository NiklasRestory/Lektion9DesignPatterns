using Lektion9Mars14DesignPatterns1.Command;
using Lektion9Mars14DesignPatterns1.Flyweight;
using Lektion9Mars14DesignPatterns1.State;

namespace Lektion9Mars14DesignPatterns1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FlyweightDemonstration flyweightDemonstration = new FlyweightDemonstration();
            //flyweightDemonstration.Run();
            CommandDemonstration commandDemonstration = new CommandDemonstration();
            //commandDemonstration.Run();
            StateDemonstration stateDemonstration = new StateDemonstration();
            stateDemonstration.Run();
        }
    }
}