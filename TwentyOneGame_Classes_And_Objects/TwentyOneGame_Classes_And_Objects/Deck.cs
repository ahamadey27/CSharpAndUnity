using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame_Classes_And_Objects
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
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
                    Cards.Add(new Card { Suit = suit, Face = face });
                }
            }
        }

        public void Shuffle(int times = 1)
        {
            Random random = new Random();
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
