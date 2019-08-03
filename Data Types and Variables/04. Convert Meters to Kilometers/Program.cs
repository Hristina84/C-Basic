using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal distance = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{(distance / 1000):f2}");
        }
    }
}
