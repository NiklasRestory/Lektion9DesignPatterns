using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.NullObject
{
    public class Car : ICar
    {
        public string Name { get; set; }
        public int MilesDriven { get; set; }

        public void Drive(int distance)
        {
            MilesDriven += distance;
        }
    }
}
