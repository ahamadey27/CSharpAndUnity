using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame_Classes_And_Objects
{
    public struct Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }

    public enum Suit //creating an enum...below values by default start at 0 and increase by one
    {
        Clubs, 
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Fve, 
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }



}
