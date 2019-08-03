using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal britishPound = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{(britishPound * 1.31M):f3}");
        }
    }
}
