﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = decimal.Parse(Console.ReadLine());
            var h = decimal.Parse(Console.ReadLine());
            var area = Math.Round(((a * h)/2) , 4);
            
            Console.WriteLine("Triangle area= {0}", area);
        }
    }
}
