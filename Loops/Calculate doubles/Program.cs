using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { 'A', 'B', 'C', 'D', 'E', 'a', 'b', 'c', 'd', 'а', 'б', 'в', 'г', 'A', 'Б', 'В', 'Г', 'Д', '(', ')', '[', ']', '\\', '\"', '\'' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //A
            if (input[0].Contains('.'))
            {
                Console.WriteLine($"A) : {input[0]}");
            }
            else
            {

                StringBuilder a = new StringBuilder(input[0]);

                List<int> listA = new List<int>();
                double resultA = 0.0;
                bool substractA = false;
                bool multipyA = false;
                bool sumA = false;


                for (int i = 0; (!input[0].Contains('.')) && i < a.Length; i++)
                {
                    if (char.IsDigit(a[i]))
                    {
                        listA.Add(a[i] - '0');
                    }
                    if (a[i] == '-' || a[i] == '−' || a[i] == 196) substractA = true;
                    if (a[i] == '*' || a[i] == 'x' || a[i] == 'X') multipyA = true;
                    if (a[i] == '+') sumA = true;
                }

                listA.Add(0);
                listA.Add(0);
                listA.Add(0);
                listA.Add(0);

                if (substractA) resultA = ((double)listA[0] / (double)listA[1]) - ((double)listA[2] / (double)listA[3]);
                else if (multipyA) resultA = ((double)listA[0] / (double)listA[1]) * ((double)listA[2] / (double)listA[3]);
                else if (sumA) resultA = ((double)listA[0] / (double)listA[1]) + ((double)listA[2] / (double)listA[3]);
                else if (listA[3] == 0) resultA = ((double)listA[0] / (double)listA[1]);

                Console.WriteLine($"A) : {Math.Round(resultA, 4)}");
            }



            //B
            if (input.Length > 1)
            {
                if (input[1].Contains('.'))
                {
                    Console.WriteLine($"B) : {input[1]}");
                }
                else
                {
                    StringBuilder b = new StringBuilder(input[1]);


                    List<int> listB = new List<int>();
                    double resultB = 0.0;
                    bool substractB = false;
                    bool multipyB = false;
                    bool sumB = false;


                    for (int i = 0; (!input[1].Contains('.')) && i < b.Length; i++)
                    {
                        if (char.IsDigit(b[i]))
                        {
                            listB.Add(b[i] - '0');
                        }
                        if (b[i] == '-' || b[i] == '−' || b[i] == 196) substractB = true;
                        if (b[i] == '*' || b[i] == 'x' || b[i] == 'X') multipyB = true;
                        if (b[i] == '+') sumB = true;
                    }

                    listB.Add(0);
                    listB.Add(0);
                    listB.Add(0);
                    listB.Add(0);

                    if (substractB) resultB = ((double)listB[0] / (double)listB[1]) - ((double)listB[2] / (double)listB[3]);
                    else if (multipyB) resultB = ((double)listB[0] / (double)listB[1]) * ((double)listB[2] / (double)listB[3]);
                    else if (sumB) resultB = ((double)listB[0] / (double)listB[1]) + ((double)listB[2] / (double)listB[3]);
                    else if (listB[3] == 0) resultB = ((double)listB[0] / (double)listB[1]);

                    Console.WriteLine($"B) : {Math.Round(resultB, 4)}");
                }

            }

            //C

            if (input.Length > 2)
            {

                if (input[2].Contains('.'))
                {
                    Console.WriteLine($"C) : {input[2]}");
                }
                else
                {
                    StringBuilder c = new StringBuilder(input[2]);

                    List<int> listC = new List<int>();
                    double resultC = 0.0;
                    bool substractC = false;
                    bool multipyC = false;
                    bool sumC = false;


                    for (int i = 0; (!input[2].Contains('.')) && i < c.Length; i++)
                    {
                        if (char.IsDigit(c[i]))
                        {
                            listC.Add(c[i] - '0');
                        }
                        if (c[i] == '-' || c[i] == '−' || c[i] == 196) substractC = true;
                        if (c[i] == '*' || c[i] == 'x' || c[i] == 'X') multipyC = true;
                        if (c[i] == '+') sumC = true;
                    }

                    listC.Add(0);
                    listC.Add(0);
                    listC.Add(0);
                    listC.Add(0);

                    if (substractC) resultC = ((double)listC[0] / (double)listC[1]) - ((double)listC[2] / (double)listC[3]);
                    else if (multipyC) resultC = ((double)listC[0] / (double)listC[1]) * ((double)listC[2] / (double)listC[3]);
                    else if (sumC) resultC = ((double)listC[0] / (double)listC[1]) + ((double)listC[2] / (double)listC[3]);
                    else if (listC[3] == 0) resultC = ((double)listC[0] / (double)listC[1]);

                    Console.WriteLine($"C) : {Math.Round(resultC, 4)}");
                }

            }

            //D

            if (input.Length > 3)
            {

                if (input[3].Contains('.'))
                {
                    Console.WriteLine($"D) : {input[3]}");
                }
                else
                {
                    StringBuilder d = new StringBuilder(input[3]);

                    List<int> listD = new List<int>();
                    double resultD = 0.0;
                    bool substractD = false;
                    bool multipyD = false;
                    bool sumD = false;


                    for (int i = 0; (!input[3].Contains('.')) && i < d.Length; i++)
                    {
                        if (char.IsDigit(d[i]))
                        {
                            listD.Add(d[i] - '0');
                        }
                        if (d[i] == '-' || d[i] == '−' || d[i] == 196) substractD = true;
                        if (d[i] == '*' || d[i] == 'x' || d[i] == 'X') multipyD = true;
                        if (d[i] == '+') sumD = true;
                    }

                    listD.Add(0);
                    listD.Add(0);
                    listD.Add(0);
                    listD.Add(0);

                    if (substractD) resultD = ((double)listD[0] / (double)listD[1]) - ((double)listD[2] / (double)listD[3]);
                    else if (multipyD) resultD = ((double)listD[0] / (double)listD[1]) * ((double)listD[2] / (double)listD[3]);
                    else if (sumD) resultD = ((double)listD[0] / (double)listD[1]) + ((double)listD[2] / (double)listD[3]);
                    else if (listD[3] == 0) resultD = ((double)listD[0] / (double)listD[1]);

                    Console.WriteLine($"D) : {Math.Round(resultD, 4)}");
                }
            }

            Console.WriteLine();



            /*

             A) .45 B) 3/5 C) 1/4 D) .35

             A) 1/6 B) 1/3 - 1/6 C) 2/3 – 1/7 D) 1/3 – 1/4 

            A) 1/4 - 1/8  B) 1/3 - 1/4 C) 1/7 D) 1/2 – 1/8 

              1/6 x 1/3

    */
        }
    }
}
