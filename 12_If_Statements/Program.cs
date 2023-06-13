using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age > 18) {
                Console.WriteLine("You can enter.");
            }
            else if(age < 0)
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                Console.WriteLine("You must be 18+ to enter.");
            }

            //----------------------------------------------------------
            
            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if(name != "")
            {
                Console.WriteLine("Hello " + name + "!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.ReadKey();
        }
    }
}
