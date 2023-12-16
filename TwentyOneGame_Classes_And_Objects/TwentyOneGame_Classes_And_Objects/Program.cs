using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame_Classes_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel Casino. What's your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money do you want to gamble away today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21?", playerName); //playerName will be inserted into {0}
            string answer = Console.ReadLine().ToLower();
            if (answer == "es" || answer == "yea" || answer == "ya" || answer == "ok" || answer == "yes" || answer == "sure")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player; //adding player to the game
                player.isActivelyPlaying = true; 
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play(); 
                }
            }

           
        }
    }
}