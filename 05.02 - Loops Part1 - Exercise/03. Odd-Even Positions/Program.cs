using System;

namespace _03.Odd_EvenPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int numN = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= numN; i++)
            {
                double currNum = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += currNum;
                    if (currNum < oddMin)
                    {
                        oddMin = currNum;
                    }
                    if (currNum > oddMax)
                    {
                        oddMax = currNum;
                    }
                }
                else if (i % 2 == 0)
                {
                    evenSum += currNum;
                    if (currNum < evenMin)
                    {
                        evenMin = currNum;
                    }
                    if (currNum > evenMax)
                    {
                        evenMax = currNum;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:F2},");

            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
            }

            Console.WriteLine($"EvenSum={evenSum:F2},");

            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }


            
          
        }
    }
}
