using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.NullObject
{
    public class CarList
    {
        List<Car> cars = new List<Car>();

        public ICar GetCarByName(string name)
        {
            foreach(Car car in cars)
            {
                if (car.Name.Equals(name))
                {
                    return car;
                }
            }
            return new CarNullObject();
        }
    }
}
