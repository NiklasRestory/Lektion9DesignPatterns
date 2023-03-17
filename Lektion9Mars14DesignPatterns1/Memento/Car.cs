using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Memento
{
    public class Car // Originator
    {
        public int Distance { get; set; }
        public int Fuel { get; set; }
        public Car(int distance, int fuel)
        {
            Distance = distance;
            Fuel = fuel;
        }
        public void Drive(int distance)
        {
            if (distance <= Fuel)
            {
                Distance += distance;
                Fuel -= distance;
            }
            else
            {
                Distance += Fuel;
                Fuel = 0;
            }
        }
        public void Refuel(int fuel)
        {
            Fuel += fuel;
        }
        public CarMemento CreateMemento()
        {
            return new CarMemento(new Car(Distance, Fuel));
        }
        public void SetMemento(CarMemento carMemento)
        {
            Distance = carMemento.Car.Distance;
            Fuel = carMemento.Car.Fuel;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Distance: " + Distance + ", Fuel: " + Fuel);
        }
    }
}
