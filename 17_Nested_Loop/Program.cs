using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Console.Write("How many rows? ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns? ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol/character? ");
            char symbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
