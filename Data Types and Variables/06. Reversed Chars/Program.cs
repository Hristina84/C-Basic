using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = new char[3];

            for (int i = 0; i < 3; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                output[i] += letter;                
                
            }
            Array.Reverse(output);
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
