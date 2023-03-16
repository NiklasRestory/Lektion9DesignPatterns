using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.FactoryMethod
{
    public class MotorBike : IBike
    {
        public void Drive()
        {
            Console.WriteLine("WRROOOOOOOOOOOOOMMMMMM");
        }
    }
}
