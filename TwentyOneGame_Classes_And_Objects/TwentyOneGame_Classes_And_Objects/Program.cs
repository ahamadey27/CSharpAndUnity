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
            Deck deck = new Deck();

            //Example 1
            //int count = deck.Cards.Count(x => x.Face == Face.Ace); //basic lamda function that counts Aces..count is the lambda function 
            // => means evaluate this on each item 
            //Console.WriteLine(count); 

            //Example 2
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //where is the lamda function here 
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face); 
            //}

            //Example 3
            List<int> numberList = new List<int>() { 1, 2, 3, 535, 235 };
            //int sum = numberList.Sum(x => x + 5); //adds five to each number 
            //int sum = numberList.Min(); //simple way to find smallest number 
            int sum = numberList.Where(x => x > 20).Sum(); //create a list where the numbers are greater than 20
            Console.WriteLine(sum); 

            
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.Read();
        }
    }
}