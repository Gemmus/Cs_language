using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "red");
            ChangeColor(car1, "silver");
            Console.WriteLine(car1.color + " " + car1.model);

            Car car2 = Copy(car1);
            Console.WriteLine(car2.color + " " + car2.model);

            Console.ReadKey();
        }
        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }
        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
    class Car
    {
        public String model;
        public String color;
        public Car(String model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }
}
