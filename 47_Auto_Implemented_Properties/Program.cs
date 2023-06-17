// Auto-implemented properties:
// Shortcut when no additional logic is required in the property.
// You do not have to define a field for a property, you only have to write get; and/or set; inside the property

using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Car car = new Car("Volvo");
            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }
    class Car
    {
        /*
        String model;
        public String Model
        {
            get { return model; }
            set { model = value; }
        }*/
        //or 
        public String Model { get; set; }
        
        public Car(String model)
        {
            this.Model = model;
        }
    }
}
