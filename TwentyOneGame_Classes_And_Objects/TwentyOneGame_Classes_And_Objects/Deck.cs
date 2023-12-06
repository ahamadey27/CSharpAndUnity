using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame_Classes_And_Objects
{
    public class Deck
    {
        public Deck() 
        public List<Card> Cards { get; set; }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {   
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++; 
                List<Card> TempList = new List<Card>();
                Random random = new Random(); 

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]); 
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList; 
            }
            return deck;
            
        }

    }
}
