using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame_Classes_And_Objects
{
    class Deck
    {
        public Deck() //constructors go on top of the class above the properties 
        {
          
            Cards = new List<Card>(); //Must create empty list first 
            //nested foreach loop
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); //this gets added to the Cards variable up top
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card); 
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
