// Static: 
// Modifier to declare a static member, which belongs to the class itself, rather than to any specific object.

using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();

            Console.ReadKey();
        }
    }

    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has began.");
        }
    }
}
