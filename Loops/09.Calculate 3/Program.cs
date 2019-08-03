using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09.Calculate_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long m = n - k;
            BigInteger kFactorial = 1;
            BigInteger nFactorial = 1;
            BigInteger mFactorial = 1;            

            for (int i = 1; i <= n; i++)
            {
                nFactorial = nFactorial * i;
                if (i <= k)
                    kFactorial = kFactorial * i;
                if (i <= m)
                    mFactorial = mFactorial * i;
            }
            Console.WriteLine(nFactorial / (kFactorial * mFactorial));
        }
    }
}
