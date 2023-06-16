// List:
// Data structure that represents a list of objects that can be accessed by index.
// Simiar to array, but can dynamically increase/decrease in size.
// Using System.Collections.Generic;

using System;
using System.Collections.Generic;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            List<String> foods = new List<String>();

            foods.Add("poke bowl");
            foods.Add("miso soup");
            foods.Add("tempura");
            foods.Add("sushi");

            foods.Remove("sushi");
            foods.Insert(0, "tamago");

            //foods.Sort();
            //foods.Reverse();
            //foods.Clear();

            foreach (String food in foods) Console.WriteLine(food);

            Console.WriteLine();
            Console.WriteLine("The item at index 2 is: " + foods[2]);

            Console.WriteLine("The list contains " + foods.Count + " items.");

            Console.WriteLine("The index of miso soup is " + foods.IndexOf("miso soup") + ".");

            Console.WriteLine("Does it contain pizza? " + foods.Contains("pizza"));
            Console.WriteLine();

            //------------------------------------------------

            String[] foodArray = foods.ToArray();
            foreach (String food in foodArray) Console.WriteLine(food);

            Console.ReadKey();
        }
    }
}
