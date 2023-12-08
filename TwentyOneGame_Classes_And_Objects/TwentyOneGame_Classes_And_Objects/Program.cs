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
            //List<Game> games = new List<Game>();
            //Game game = new TwentyOneGame(); //example of polymorphism...ability of a class to morph into its inheriting class to give certain advantages
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "hammer", "bill", "sam" };
            game.ListPlayers();
            Console.ReadLine(); 
            //games.Add(game); 


            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.Read();
        }
    }
}