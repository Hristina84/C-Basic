﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Podouble_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var checkOnX = (x == x1 || x == x2);
            var checkOnY = (y == y1 || y == y2);
            var checkInX = (x >= x1 && x <= x2);
            var checkInY = (y >= y1 && y <= y2);

            if (checkOnX && checkInY || checkOnY && checkInX)
            { Console.WriteLine("Border"); }

            else
            { Console.WriteLine("Inside / Outside"); }
        }
    }
}
