﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = Math.Round(((rad * 180) / Math.PI), 0);            

            Console.WriteLine("deg= {0}", deg);
            
        }
    }
}
