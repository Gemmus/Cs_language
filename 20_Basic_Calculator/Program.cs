using System;
using System.Data.Common;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            String operation;
            bool calculate = true;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("      Calculator Programme     ");
            Console.WriteLine("-------------------------------");

            while (calculate)
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                operation = "";

                while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                {
                    Console.Write("Enter operatore ( + - * / ): ");
                    operation = Console.ReadLine();
                }

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine(num1 + " + " + num2 + " = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine(num1 + " - " + num2 + " = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine(num1 + " * " + num2 + " = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine(num1 + " / " + num2 + " = " + result);
                        break;
                }

                Console.WriteLine("Do you wish to start a new calculation (Y/N)? ");
                String answer = Console.ReadLine().ToUpper();

                if (answer == "N") calculate = false; else calculate = true;
                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the calculator!");
            Console.WriteLine("Bye!");

            Console.ReadKey();
        }
    }
}
