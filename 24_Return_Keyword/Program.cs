using System;
using System.Data.Common;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            double x;
            double y;
            double result;

            Console.Write("Enter first number: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.Write(x + " * " + y + " = " + result);
            Console.ReadKey();
        }
    
    static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
