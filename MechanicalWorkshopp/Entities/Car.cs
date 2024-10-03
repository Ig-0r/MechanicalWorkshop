using System;

namespace MechanicalWorkshop.Entities
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }        
        public int Year { get; set; }
        public double Value { get; set; }
        public string Engine { get; set; }

        public Car() { }

        public Car(string make, string model, int year, double value, string engine)
        {
            Make = make;
            Model = model;
            Year = year;
            Value = value;
            Engine = engine;            
        }
    }
}
