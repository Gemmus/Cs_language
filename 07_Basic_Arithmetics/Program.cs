using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            int friends = 10;
            /*
            friends = friends + 1;
            friends++;
            friends += 2;
            Console.WriteLine(friends);
            */
            /*
            friends = friends - 1;
            friends--;
            friends -= 2;
            Console.WriteLine(friends);
            */
            /*
            friends = friends * 2;
            friends *= 2;
            Console.WriteLine(friends);
            */
            /*
            friends = friends / 2;
            friends /= 2;
            Console.WriteLine(friends);
            */
            int remainder = friends % 3;
            Console.WriteLine(remainder);

            Console.ReadKey();
        }
    }
}
