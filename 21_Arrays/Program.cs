using System;
using System.Data.Common;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            String[] cars = { "BMW", "Mustang", "Corvette"};

            cars[0] = "Tesla";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write(cars[i] + " ");
            }

            Console.WriteLine();

            //------------------------------------------------

            String[] cats = new string[5];

            cats[0] = "Mirri";
            cats[1] = "Spots";

            for (int i = 0; i < cats.Length; i++)
            {
                Console.Write(cats[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
