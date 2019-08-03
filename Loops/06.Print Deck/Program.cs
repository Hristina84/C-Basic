using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Print_Deck
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardSign = Console.ReadLine();

            int num = 0;

            if (cardSign == "J" || cardSign == "Q" || cardSign == "K" || cardSign == "A")
            {
                num = 10;
            }
            else
            {
                num = int.Parse(cardSign);
            }
            
            for (int i = 2; i <= num; i++)
            {
                Console.WriteLine($"{i} of spades, {i} of clubs, {i} of hearts, {i} of diamonds");
            }
            if (cardSign == "J")
            {
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
            }
            else if (cardSign == "Q")
            {
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
            }
            else if (cardSign == "K")
            {
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
            }
            else if (cardSign == "A")
            {
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
            }

        }
    }
}
