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

        // Builder Design Pattern allows the constructor of the object being made to
        // remain simple, and can contain logic that concerns the creation of that
        // kind of object.
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

        // The constructor first sets up default values, then there's a bunch
        // of setters for the various values. They give back the builder itself,
        // allowing us to chain the setters.
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

        // Finally, there's only one constructor call that builds the object itself,
        // located inside a Build function that takes all the values, default or not,
        // and calls the constructor of the object to be built.
        public Bike Build()
        {
            return new Bike(name, model, countryOfOrigin, yearMade, numberOfGears, frontWheel, backWheel);
        }
    }
}
