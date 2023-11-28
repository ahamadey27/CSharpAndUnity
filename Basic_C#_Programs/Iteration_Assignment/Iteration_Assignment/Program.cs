using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foodArray = { "chicken", "beef", "salami", "ham", "beer" };
            Console.WriteLine("what are you having for dinner?");
            string userInput = Console.ReadLine(); 
            for (int n = 0; n < foodArray.Length; ++n)
            {
                Console.WriteLine(foodArray[n] + " This is what I'm having for dinner");
            }
            Console.Read(); 

            //This will output each array concatenated with the writeline


        }
    }
}
