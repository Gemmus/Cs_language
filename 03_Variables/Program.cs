using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            int age = 23;
            Console.WriteLine("Your age is " + age + ".");

            double height = 175.2;
            Console.WriteLine("You are " + height + " cm tall.");

            bool alive = true;
            Console.WriteLine("Alive? " + alive + ".");

            char symbol = '@';
            Console.WriteLine("Your symbol is: " + symbol);

            String name = "Jack";
            Console.WriteLine("Hello " + name + "!");

            String userName = symbol + name;
            Console.WriteLine("Your username is: " + userName);

            Console.ReadKey();
        }
    }
}
