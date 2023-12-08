using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame_Classes_And_Objects
{
    public class TwentyOneGame : Game , IWaslkAway
    {
        public override void Play() //must oput override method to activate since Game is abstract 
        {

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
