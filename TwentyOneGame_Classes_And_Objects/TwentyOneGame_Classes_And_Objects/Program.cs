﻿using System;
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
            Deck deck = new Deck(); 
            deck.shuffle();          

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count); 
            Console.WriteLine("Times shuffled: {0}", timesShuffled); 
            Console.Read();                          
        }

       

    }
}
