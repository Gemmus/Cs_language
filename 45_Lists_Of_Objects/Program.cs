using System;
using System.Collections.Generic;

namespace Cs_language
{
    class Program
    {
    static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("Alan"));
            players.Add(new Player("Nora"));
            players.Add(new Player("Chad"));

            foreach(Player player in players) Console.WriteLine(player);

            Console.ReadKey();
        }
    }
    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}
