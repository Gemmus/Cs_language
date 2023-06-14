using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            String name = "";

            while (name == "")
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
            }
            Console.WriteLine("Hello " + name + "!");

            Console.ReadKey();
        }
    }
}
