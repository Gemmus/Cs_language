/* String Interpolation:
 * Allows us to insert variables into a string literal.
 * Precede a string literal with $.
 * {} are placeholders
 */

using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            String firstName = "Adele";
            String lastName = "Jones";
            int age = 21;

            Console.WriteLine($"Hello {firstName} {lastName}!");
            Console.WriteLine($"You are {age} years old.");

            Console.ReadKey();
        }
    }
}
