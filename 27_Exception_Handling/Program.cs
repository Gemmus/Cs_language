/* Exception: errors taht occur during execution
 * try = try some code that is cosidered "dangerous"
 * catch = catches and handles exceptions when they occur
 * finally = always executes regardless if exception is caught or not
 */
using System;
using System.ComponentModel.Design;
using System.Data.Common;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            int x; 
            int y;
            double result;

            try
            {
                Console.Write("Enter first number: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;
                Console.WriteLine(result);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Enter numbers please.");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            finally // for closing opened files or to reset anything 
            {
                Console.WriteLine("Thank you!");
            }

            Console.ReadKey();
        }
    }
}
