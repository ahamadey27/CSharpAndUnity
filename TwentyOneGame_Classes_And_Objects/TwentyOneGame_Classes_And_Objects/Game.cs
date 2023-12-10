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
        public string Dealer { get; set; }

        public abstract void Play(); //any class that's inheriting this class must inherit it's properties 

        public virtual void ListPlayers() //virtual method in abstract class means this method get inherited by inherting class but has abilty to override
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player); 
            }
        }
    }
}
