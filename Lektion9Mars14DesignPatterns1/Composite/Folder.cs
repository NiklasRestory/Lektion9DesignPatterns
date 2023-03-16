using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Composite
{
    public class Folder : Component
    {
        List<Component> contents = new List<Component>();

        public Folder(string name) : base(name)
        {
        }

        public void AddComponent(Component component)
        {
            contents.Add(component);
        }

        public override void PrintContents()
        {
            Console.WriteLine("This is folder: " + Name + ". I contain: ");
            foreach (Component component in contents)
            {
                component.PrintContents();
            }
            Console.WriteLine("Exiting " + Name);
        }
    }
}
