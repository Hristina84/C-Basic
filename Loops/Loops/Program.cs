using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string proba = Console.ReadLine();

            char text = char.Parse(Console.ReadLine());
            int num = (int)Char.GetNumericValue(text);

            Console.WriteLine(num);
        }
    }
}
