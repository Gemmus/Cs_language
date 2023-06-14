using System;
using System.Data.Common;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            String name = "Liza";
            singHappyBday(name, 4);

            Console.ReadKey();
        }
    
    static void singHappyBday(String name, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Happy Birthday to You!");
                Console.WriteLine("Happy Birthday to You!");
                Console.WriteLine("Happy Birthday dear " + name + "!");
                Console.WriteLine("Happy Birthday to You!");
                Console.WriteLine();
            }
        }
    }
}
