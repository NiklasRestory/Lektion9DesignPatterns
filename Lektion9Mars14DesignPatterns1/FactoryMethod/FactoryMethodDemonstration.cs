using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.FactoryMethod
{
    public class FactoryMethodDemonstration
    {
        public void Run()
        {
            MakeBikeAndGo(new MotorBikeFactory());
            Console.WriteLine(" --- ");
            MakeBikeAndGo(new BikeFactory());
        } 

        // The factories can be sent along to various functions to make
        // the functions work with creating different kinds of objects.
        // MakeBikeAndGo here will behave differently depending on if
        // I send along a MotorBikeFactory that makes MotorBikes compared
        // to if I send along a normal BikeFactory that makes bikes.
        public void MakeBikeAndGo(BikeFactory bikeFactory)
        {
            IBike bike = bikeFactory.GetBike();
            bike.Drive();
        }
    }
}
