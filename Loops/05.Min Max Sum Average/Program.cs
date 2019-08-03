using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Min_Max_Sum_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double minNum = double.MaxValue;
            double maxNum = double.MinValue;
            double sum = 0;
            double avg = 0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num > maxNum)
                {
                    maxNum = num;
                }
                if (num < minNum)
                {
                    minNum = num;
                }
                sum +=num;
                avg = sum / i;
            }                   
            Console.WriteLine($"min={minNum:f2}");
            Console.WriteLine($"max={maxNum:f2}");
            Console.WriteLine($"sum={sum:f2}");
            Console.WriteLine($"avg={avg:f2}");

        }
    }
}
