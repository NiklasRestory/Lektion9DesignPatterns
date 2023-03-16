using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Singleton
{
    public class SingletonDemonstration
    {
        public void Run()
        {
            //ProgramSettings programSettings = new ProgramSettings(60, true, 100);
            ProgramSettingsSingleton programSettings = ProgramSettingsSingleton.Instance;
            Console.WriteLine("Frames per second: " + programSettings.FramesPerSecond);
            programSettings.FramesPerSecond = 22;
            Console.WriteLine("Frames per second: " + programSettings.FramesPerSecond);

            ProgramSettingsSingleton programSettings2 = ProgramSettingsSingleton.Instance;
            Console.WriteLine("Frames per second on second get: " + programSettings2.FramesPerSecond);
        }
    }
}
