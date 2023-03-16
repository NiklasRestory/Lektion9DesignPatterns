using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Singleton
{
    public class ProgramSettingsSingleton
    {
        public int FramesPerSecond { get; set; }
        public bool Autosave { get; set; }
        public int GraphicSettings { get; set; } // from 0 to 100

        // static means the variable belongs to the class, not the object.
        private static ProgramSettingsSingleton instance = new ProgramSettingsSingleton(60, true, 100);
        
        // A static function/variable is called from the class, not an object.
        // A static function cannot interact with variables that are not static,
        // since non-static variables belong to objects, and static functions
        // concern no objects, hence doesn't have those values to retrieve.
        public static ProgramSettingsSingleton Instance { 
            get { return instance; } 
        }
        // The singleton design pattern is designed to minimize the amount of global
        // values we have by putting them in the same single object, that we then make
        // available everywhere. It has a private constructor, making creation of the object
        // only possible in the class itself. Then it's created only once, with a static getter
        // for retrieving the object anywhere. However, it is worth noting many don't
        // like the Singleton pattern and see it as something to avoid. Not extendable.
        private ProgramSettingsSingleton(int framesPerSecond, bool autosave, int graphicSettings)
        {
            FramesPerSecond = framesPerSecond;
            Autosave = autosave;
            GraphicSettings = graphicSettings;
        }
    }
}
