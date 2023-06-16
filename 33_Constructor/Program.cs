using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Human human1 = new Human("Richard", 30);
            human1.Eat();

            Human human2 = new Human("Jane", 48);
            human2.Sleep();
 
            Console.ReadKey();
        }
    }

    class Human
    {
        public String name;
        public int age;

        public Human(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

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
