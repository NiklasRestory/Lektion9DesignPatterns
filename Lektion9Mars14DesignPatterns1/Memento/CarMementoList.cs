using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Memento
{
    public class CarMementoList // Caretaker
    {
        Stack<CarMemento> mementoStack = new Stack<CarMemento>();

        public void Push(CarMemento carMemento)
        {
            // Push is the function to add an item to a stack.
            mementoStack.Push(carMemento);
        }
        public CarMemento Pop()
        {
            // Pop is a word for retrieving the most newly added
            // item from the stack, and remove it from the stack
            // at the same time.
            return mementoStack.Pop();
        }
    }
}
