using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Memento
{
    public class CarMemento
    {
        public Car Car { get; set; }
        public CarMemento(Car car)
        {
            Car = car;
        }
    }
}
