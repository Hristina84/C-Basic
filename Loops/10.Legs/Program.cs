using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10.Legs
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger legs = BigInteger.Parse(Console.ReadLine());

            BigInteger counter = 0;

            for (int i = 0; i < legs; i++)
            {
                for (int j = 0; j < legs; j++)
                {
                    for (int k = 0; k < legs ; k++)
                    {
                        if (i * 2 + j * 5 + k * 7 == legs)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
