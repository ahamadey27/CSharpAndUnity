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
            // Instantiated new object called deck and assinged to variable called deck 
            Deck deck = new Deck(); //should have deck of 52 cards 

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count); 

         
            Console.Read(); 








            ////deck has a property called cared which is adata type called list card,
            ////and to assign to list have to instantiate with a new data type keyword card.   
            //deck.Cards = new List<Card>(); 

            //Card cardOne = new Card(); //how to instantiate a new object 
            ////after typing object name and dot, hover over
            ////and select "Face" which will assign {get; set;} properties 
            //cardOne.Face = "Queen"; 
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne); //just added one ard to the deck


            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit); // how to write "Queen of Spades"
            Console.ReadLine(); 
        }

    }
}
