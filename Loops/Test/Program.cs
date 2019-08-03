using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row <= 10; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            /*
             for (int i = 1; i <= 10 ; i ++)
            {
                string line = new string('*', i);
                Console.WriteLine(new string('*', i));
            }
             */
        }
    }
}
