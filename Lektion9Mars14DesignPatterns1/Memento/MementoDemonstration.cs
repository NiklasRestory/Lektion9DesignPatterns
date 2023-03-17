using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Memento
{
    public class MementoDemonstration
    {
        Car car = new Car(0, 100);
        CarMementoList caretaker = new CarMementoList();
        public void Run()
        {
            Console.WriteLine("Original state: ");
            car.PrintInfo();

            Drive(50);
            Drive(26);
            Drive(255);
            Refuel(38);
            Drive(20);

            Undo();
            Undo();
            Undo();
            Undo();
            Undo();
        }

        private void Drive(int distance)
        {
            CarMemento carMemento = car.CreateMemento();
            caretaker.Push(carMemento);
            car.Drive(distance);
            Console.Write("Drove to ");
            car.PrintInfo();
        }
        private void Refuel(int fuel)
        {
            CarMemento carMemento = car.CreateMemento();
            caretaker.Push(carMemento);
            car.Refuel(fuel);
            Console.Write("Rfuel to ");
            car.PrintInfo();
        }
        private void Undo()
        {
            CarMemento carMemento = caretaker.Pop();
            car.SetMemento(carMemento);
            Console.Write("Undid to ");
            car.PrintInfo();
        }
    }
}
