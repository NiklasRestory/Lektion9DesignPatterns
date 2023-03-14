using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Builder
{
    public class Bike
    {
        string name;
        string model;
        string countryOfOrigin;
        int yearMade;
        int numberOfGears;
        Wheel frontWheel;
        Wheel backWheel;

        public Bike(string name, string model, string countryOfOrigin, int yearMade, int numberOfGears, Wheel frontWheel, Wheel backWheel)
        {
            this.name = name;
            this.model = model;
            this.countryOfOrigin = countryOfOrigin;
            this.yearMade = yearMade;
            this.numberOfGears = numberOfGears;
            this.frontWheel = frontWheel;
            this.backWheel = backWheel;
        }


    }
}
