using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Console.Write("Hey!"); // Does not add a line.
            Console.WriteLine("Hello World!.");

            // Adding one line comment.
            /* Adding
             * multiple 
             * line
             * comment
             */

            Console.WriteLine("Bye"); // Adding tab.
            Console.WriteLine("Bye\bbye"); // Adding backspace. -> ByBye
            Console.WriteLine("Bye\n"); // Adding new line.

            Console.ReadKey(); // Hides the text that is followed.
        }
    }
}
