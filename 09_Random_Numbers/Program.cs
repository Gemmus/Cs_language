using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Random random = new Random();

            int num1 = random.Next(1, 7); // Random number between 1, 6
            Console.WriteLine(num1);

            double num2 = random.NextDouble(); // Random number between 0, 1
            Console.WriteLine(num2);

            Console.ReadKey();
        }
    }
}
