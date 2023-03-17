using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.NullObject
{
    public class NullObjectDemonstration
    {
        public void Run()
        {
            CarList carList = new CarList();
            ICar car = carList.GetCarByName("rbgiesuogfn");
            car.Drive(34);
        }
    }
}
