// Generic
// Not specific to a particular data type.
// Add <T> to: classes, methods, fields, etc.
// Allows for code reusability for different data types.

using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            Console.ReadKey();
        }
    public static void displayElements<T>(T[] array)
        {
            foreach (T item in array) Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
