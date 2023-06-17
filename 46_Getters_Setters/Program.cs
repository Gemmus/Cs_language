// Getters and Setters:
// Add security to fields by encapsulation.
// They are accessors found within properties.

// Properties: combine aspects of both fields and methods (share name with a field)
// Get accessor: used to return the property value
// Get accessor: used to assign a new value
// Value keyword: defines the value being assigned by the set (parameter)

using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Car car = new Car(400);

            car.Speed = -10000;
            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }
    }
    class Car
    {
        public int speed;

        public Car(int speed)
        {
            Speed = speed;
        }
        public int Speed
        {
            get { return speed; } //read value
            set                   // write value
            {
                if(value > 250)
                {
                    speed = 250;
                }
                else if(value < 0)
                {
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}
