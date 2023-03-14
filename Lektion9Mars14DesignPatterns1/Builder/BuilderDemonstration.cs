using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Builder
{
    public class BuilderDemonstration
    {
        public void Run()
        {
            BikeBuilder bikeBuilder = new BikeBuilder();

            Bike bike = bikeBuilder.Gears(2).FrontWheel(new Wheel()).Year(1994).Country("France").Name("Cool Bike").Model("Uncool model").BackWheel(new Wheel()).Build();

            bikeBuilder = new BikeBuilder();
            Bike bike2 = bikeBuilder.FrontWheel(new Wheel()).BackWheel(new Wheel()).Name("My bike").Build();

            bikeBuilder = new BikeBuilder();
            Bike bike3 = bikeBuilder.Build();
        }
    }
}
