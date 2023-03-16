using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.FactoryMethod
{
    public class BikeFactory
    {
        // Factory Method is a design pattern intended to be used so
        // that we can in an extendable way make the same function
        // give back different kinds of objects. We can have a factory
        // here, that has GetBike here. Bike can be replaced with
        // whatever kind of object we want to create.
        public IBike GetBike()
        {
            IBike bike = CreateBike();
            return bike;
        }

        // GetBike calls CreateBike, a virtual function made to be
        // overwritten if we have other kinds of factories. Like,
        // MotorBikeFactory will create its own IBike, MotorBike.
        protected virtual IBike CreateBike()
        {
            return new Bike();
        }
    }
}
