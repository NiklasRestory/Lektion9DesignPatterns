using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Composite
{
    // The Composite Design Pattern is a structural Design Pattern
    // that is deviced to allow us to have both objects and lists
    // of the objects in the same list.
    // We have an interface or an abstract class that both
    // of these implement/inherit from. Then, in the folder class,
    // it contains a list of these Components. Because both the
    // file and the folder inherit from Component, both can be
    // in a list of Components. And that's pretty much it.
    public abstract class Component
    {
        public string Name { get; set; }
        public Component(string name)
        {
            Name = name;
        }

        // If I want to make sure a certain function exists in
        // both the object and the containing folder/group, I
        // can make sure an abstract function exists if I
        // use an abstract class, or just simply that the function
        // is in the interface if I use an interface.
        public abstract void PrintContents();
    }
}
