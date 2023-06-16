using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.name = "Richard";
            human1.age = 30;

            human1.Eat();

            Human human2 = new Human();
            human2.name = "Jane";
            human2.age = 48;

            human2.Sleep();
 
            Console.ReadKey();
        }
    }

    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating.");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping.");
        }
    }
}
