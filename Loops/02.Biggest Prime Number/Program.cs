using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Biggest_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            var primes = new bool[N + 1];

            for (int i = 2; i <= N; i++)
            {
                primes[i] = true;
            }
            for (int i = 2; i < N; i++)
            {

                if (primes[i] == true)
                {
                    for (int j = 2; j * i <= N; j++)
                    {
                        primes[j * i] = false;
                    }
                }
            }
            for (long i = N; i >= 0; i--)
            {
                if (primes[i] == true)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
