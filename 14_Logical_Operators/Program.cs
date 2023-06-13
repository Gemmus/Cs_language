using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {

            Console.WriteLine("What's the temnperature? (Celsius) ");
            double temp = Convert.ToDouble(Console.ReadLine());

            bool sunny = true;

            if (sunny && temp > 20) Console.WriteLine("What a lovely day!");
            else if (sunny || temp > 20) Console.WriteLine("At least it's something.");
            else if (!sunny && temp < 20) Console.WriteLine("What a chilly day!");

            Console.ReadKey();
        }
    }
}
