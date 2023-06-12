// Type casting:
// Converting a value to a different data type.
// Useful when user input (string) is accepted.

using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine();

            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());
            Console.WriteLine();

            int e = 321;
            String f = Convert.ToString(e);
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());
            Console.WriteLine();

            String g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(h);
            Console.WriteLine(h.GetType());
            Console.WriteLine();

            String i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j);
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}
