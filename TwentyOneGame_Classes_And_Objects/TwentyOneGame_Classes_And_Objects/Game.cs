using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame_Classes_And_Objects
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }  

        public abstract void Play();

        public virtual void ListPlayers() 
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player); 
            }
        }
    }
}
