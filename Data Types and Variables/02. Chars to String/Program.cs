using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                char digit = char.Parse(Console.ReadLine());

                letter += digit;
            }
            Console.WriteLine(letter);
        }
    }
}
