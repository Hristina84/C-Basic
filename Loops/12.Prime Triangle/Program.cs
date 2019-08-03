using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Prime_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int counter = 2;

            for (int i = 2; i <= n; i++)
            {
                if (n % i != 0)
                {
                    counter++;
                }
            }
            for (int col = 2; col <= n; col++)
            {
                for (int row = 1; row <= counter; row++)
                {
                    Console.Write(col + " ");
                }

            }

        }
    }
}

