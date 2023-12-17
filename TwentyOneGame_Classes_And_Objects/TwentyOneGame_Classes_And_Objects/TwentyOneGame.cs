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
                player.Hand = new List<Card>();
                player.Stay = false; 
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet!"); 

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet); 
                if (!successfullyBet)
                {
                    return; 
                }
                Bets[player] = bet;              
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
