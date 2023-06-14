using System;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;

            while (playAgain)
            {
                player = "";
                computer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER OR SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch(random.Next(1, 4)) 
                {
                    case 1: computer = "ROCK"; break;
                    case 2: computer = "PAPER"; break;
                    case 3: computer = "SCISSORS"; break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK") Console.WriteLine("It's a draw.");
                        else if (computer == "PAPER") Console.WriteLine("You lose.");
                        else if (computer == "SCISSORS") Console.WriteLine("You win.");
                        break;
                    case "PAPER":
                        if (computer == "ROCK") Console.WriteLine("You win.");
                        else if (computer == "PAPER") Console.WriteLine("It's a draw.");
                        else if (computer == "SCISSORS") Console.WriteLine("You lose.");
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK") Console.WriteLine("Computer wins.");
                        else if (computer == "PAPER") Console.WriteLine("You win.");
                        else if (computer == "SCISSORS") Console.WriteLine("It's a draw.");
                        break;
                }

                Console.WriteLine("Would you like to play again (Y/N)? ");
                String answer  = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "N") playAgain = false;
                Console.WriteLine();

            }

            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Bye!");

            Console.ReadKey();
        }
    }
}
