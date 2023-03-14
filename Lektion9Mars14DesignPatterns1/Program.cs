using Lektion9Mars14DesignPatterns1.Command;
using Lektion9Mars14DesignPatterns1.Flyweight;

namespace Lektion9Mars14DesignPatterns1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FlyweightDemonstration flyweightDemonstration = new FlyweightDemonstration();
            //flyweightDemonstration.Run();
            CommandDemonstration commandDemonstration = new CommandDemonstration();
            commandDemonstration.Run();
        }
    }
}