// ToString():
// Converts an object to its string representation, so that it is suitable for display.

using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car);

            Console.ReadLine();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override String ToString()
        {
            return "This is a " + make + " " + model + ".";
        }
    }
}
