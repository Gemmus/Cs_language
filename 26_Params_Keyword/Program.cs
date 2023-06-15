/* Params keyword:
 * A method parameter that takes a variable number of arguments.
 * The parameter type must be a single - dimensional array.
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
            double total = CheckOut(3.99, 5.75, 15, 15.25);
            Console.WriteLine(total);

            Console.ReadKey();
        }
    
    static double CheckOut(params double[] prices) 
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}
