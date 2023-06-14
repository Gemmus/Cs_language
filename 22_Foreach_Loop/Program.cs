using System;
using System.Data.Common;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            String[] cats = { "Mirri", "Spots", "Snowball", "Fluffy" };

            foreach (String cat in cats) Console.Write(cat + " ");

            Console.ReadKey();
        }
    }
}
