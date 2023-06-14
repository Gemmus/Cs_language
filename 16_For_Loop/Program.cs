using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i+=3) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //------------------------------------------

            for (int j = 10; j > 0; j--)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("Happy New Year!");

            Console.ReadKey();
        }
    }
}
