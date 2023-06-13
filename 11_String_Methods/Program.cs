using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {

            String fullName = "Chloe Moore";

            /*
            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);

            fullName = fullName.ToLower();
            Console.WriteLine(fullName);
            */

            String userName = fullName.Insert(0, "@");  
            Console.WriteLine(userName);

            Console.WriteLine(fullName.Length);

            //--------------------------------------------------------

            String firstName = fullName.Substring(0, 5); // (starting index, number of chars)
            String lastName = fullName.Substring(6, 5); // (sxtarting index, number of chars)
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            //--------------------------------------------------------

            String phoneNumber = "123-456-7890";
            phoneNumber = phoneNumber.Replace("-", "");
            Console.WriteLine(phoneNumber);

            Console.ReadKey();
        }
    }
}
