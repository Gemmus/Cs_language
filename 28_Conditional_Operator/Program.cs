/* Conditional Operator:
 * Used in conditional assignment if a condition is true / false.
 * (condition) ? x : y
 */

using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            double temperature = 20;

            Console.WriteLine((temperature >= 18) ? "It's warm outside." : "It's cold outside.");

            Console.ReadKey();
        }
    }
}
