using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame_Classes_And_Objects
{
    public class TwentyOneGame : Game , IWaslkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play() 
        {
            Dealer = new TwentyOneDealer(); 
            foreach (Player player in Players)
            {
                
            }

        }

        public override void ListPlayers()
        {
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException(); 
        }
    }
}
