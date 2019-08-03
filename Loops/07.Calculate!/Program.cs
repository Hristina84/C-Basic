using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Calculate_
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            long numFactorial = 1;
            decimal sum = 1;

            for (long i = 1; i <= n; i++)
            {
                numFactorial = numFactorial * i;
                sum += numFactorial / (decimal)Math.Pow(x, i);
            }
            Console.WriteLine($"{sum:f5}");
        }
    }
}
