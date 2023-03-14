using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Prototype
{
    public class Robot : IPrototype
    {
        public string Name { get; set; }
        public int KwPH { get; set; }
        private string purpose;
        private Human designer;

        public Robot(string name, int kwPH, string purpose, Human human)
        {
            Name = name;
            KwPH = kwPH;
            this.purpose = purpose;
            designer = human;
        }
        public Robot(Robot robot)
        {
            Name = robot.Name;
            KwPH = robot.KwPH;
            purpose = robot.purpose;
            designer = robot.designer; // Shallow Copy. Both robots will have the same designer.
            designer = (Human)robot.designer.Clone(); // Deep Copy. Even reference values within will be cloned.
                                                      // New object will be created for each.
        }

        public IPrototype Clone()
        {
            return new Robot(this);
        }
    }
}
