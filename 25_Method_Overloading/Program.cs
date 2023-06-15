/* Method overload:
 * Methods that share same name, but different parameters.
 * name + parameters = signature
 * methods must have a unique signature
 */

using System;
using System.Data.Common;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            double total;
            total = Multiply(2, 3, 4);
            Console.WriteLine(total);

            Console.ReadKey();
        }
    
    static double Multiply(double x, double y)
        {
            return x * y;
        }
     static double Multiply(double x, double y, double z)
        {
            return x * y * z;
        }
    }
}
