using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crooked_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int sum = 80;
            int n = 0;

            while (sum >= 9)
            {
                foreach (char item in num)
            {
                if (item == '.')
                {
                    n = 0;
                }
                else
                {
                    n = (int)Char.GetNumericValue(item);
                }
                sum += n;
            }            

              
                    n = sum % 10;
                    sum += n;

                    sum = sum / 10;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
