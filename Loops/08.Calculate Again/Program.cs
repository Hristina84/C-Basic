using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calculate_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            BigInteger kFactorial = 1;
            BigInteger nFactorial = 1;
            BigInteger sum = 0;

            for (int i = 1; i <= n; i++)
            {
                nFactorial = nFactorial * i;
                if (i <= k)
                    kFactorial = kFactorial * i;                
            }            
            Console.WriteLine(nFactorial / kFactorial);
        }
    }
}
