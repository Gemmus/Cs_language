using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(name + " is " + age + " years old.");

            Console.ReadKey();
        }
    }
}
