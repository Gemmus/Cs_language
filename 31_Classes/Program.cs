using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();
 
            Console.ReadKey();
        }
    }

    class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello! Welcome to the program!");
        }
        public static void Waiting()
        {
            Console.WriteLine("I am waiting...");
        }
        public static void Bye()
        {
            Console.WriteLine("Bye! Thanks for visiting!");
        }
    }
}
