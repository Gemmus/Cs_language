// Abstract classes:
// Modifier that indicates missing components or incomplete implementation.
// In this example the Vehicle class is an incomplete implementation.

using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Car car = new Car(); 
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            
            Console.ReadKey();
        }
    }

    abstract class Vehicle
    {
        public int speed = 0;
        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}
