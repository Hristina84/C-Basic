﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {                
                switch(text[i])
                {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                }

                //if(text[i] == 'a')
                //{ sum += 1};
            }

            Console.WriteLine(sum);
        }
    }
}
