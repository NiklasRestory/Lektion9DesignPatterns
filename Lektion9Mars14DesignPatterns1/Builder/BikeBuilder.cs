using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Builder
{
    public class BikeBuilder
    {
        string name;
        string model;
        string countryOfOrigin;
        int yearMade;
        int numberOfGears;
        Wheel frontWheel;
        Wheel backWheel;

        public BikeBuilder()
        {
            name = "";
            model = "";
            countryOfOrigin = "";
            numberOfGears = 0; // means gearless bike
            yearMade = 0;
            frontWheel = new Wheel();
            backWheel = new Wheel();
        }

        public BikeBuilder Name(string name)
        {
            this.name = name;
            return this;
        }
        public BikeBuilder Model(string model)
        {
            this.model = model;
            return this;
        }
        public BikeBuilder Country(string country)
        {
            countryOfOrigin = country;
            return this;
        }
        public BikeBuilder Gears(int gears)
        {
            numberOfGears = gears;
            return this;
        }
        public BikeBuilder Year(int yearMade)
        {
            this.yearMade = yearMade;
            return this;
        }
        public BikeBuilder FrontWheel(Wheel wheel)
        {
            frontWheel = wheel;
            return this;
        }
        public BikeBuilder BackWheel(Wheel wheel)
        {
            backWheel = wheel;
            return this;
        }

        public Bike Build()
        {
            return new Bike(name, model, countryOfOrigin, yearMade, numberOfGears, frontWheel, backWheel);
        }
    }
}
