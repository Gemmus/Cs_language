using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Console.WriteLine("Enter a number(1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                default: Console.WriteLine("Invalid input."); break;
                case 1: Console.WriteLine("It's Monday."); break;
                case 2: Console.WriteLine("It's Tuesday."); break;
                case 3: Console.WriteLine("It's Wedday."); break;
                case 4: Console.WriteLine("It's Thursday."); break;
                case 5: Console.WriteLine("It's Friday."); break;
                case 6: Console.WriteLine("It's Saturday."); break;
                case 7: Console.WriteLine("It's Sunday."); break;
            }

            Console.ReadKey();
        }
    }
}
