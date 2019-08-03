using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger pokePower = BigInteger.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            long counter = 0;
            BigInteger currentPokePower = pokePower;
            decimal percent = 0;

            while (currentPokePower >= distanceBetweenTargets)
            {
                currentPokePower = currentPokePower - distanceBetweenTargets;

                percent = (decimal)currentPokePower / (decimal)pokePower;
                
                if (percent == 0.5M && exhaustionFactor != 0)
                {
                    currentPokePower = currentPokePower / exhaustionFactor;
                    
                }
                counter++;
            }
            Console.WriteLine(currentPokePower);
            Console.WriteLine(counter);



        }
    }
}
