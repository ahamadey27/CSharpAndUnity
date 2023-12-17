using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame_Classes_And_Objects
{
    public class Player
    {
        public Player(string name, int beginningBalace) //simple constructor
        {
            Hand = new List<Card>();
            Balance = beginningBalace;
            Name = name; 
        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game; 
        }

        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game; 
        }
    }
}
