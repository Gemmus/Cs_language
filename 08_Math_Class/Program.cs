using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            double x = 3;
            double a = Math.Pow(x, 3);
            Console.WriteLine(a);

            double b = Math.Sqrt(x);
            Console.WriteLine(b);

            double c = Math.Abs(x);
            Console.WriteLine(c);

            double y = 3.14;
            double d = Math.Round(y);
            Console.WriteLine(d);

            double e = Math.Ceiling(y);
            Console.WriteLine(e);

            double f = Math.Floor(y);
            Console.WriteLine(f);

            double g = Math.Max(x, y);
            Console.WriteLine(g);

            double h = Math.Min(x, y);
            Console.WriteLine(h);

            Console.ReadKey();
        }
    }
}
