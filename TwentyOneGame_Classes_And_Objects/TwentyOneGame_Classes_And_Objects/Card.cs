using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame_Classes_And_Objects
{
    public class Card
    {
        public Card() //this is a constructor (values assigned to a class upon creation)
        {
            Suit = "Spades";
            Face = "Two";

        }
        //The card class has a property of data type string and you
        //can get and set that property...
        //making public makes it accesable to other parts of the program
        public string Suit { get; set; } 
        public string Face { get; set; }
    }


}
