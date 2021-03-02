using System;

namespace _05.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numN = int.Parse(Console.ReadLine());

            int countNumsDivBy2 = 0;
            int countNumsDivBy3 = 0;
            int countNumsDivBy4 = 0;

            for (int i = 1; i <= numN; i++)
            {
                int numsForDivide = int.Parse(Console.ReadLine());

                if (numsForDivide % 2 == 0)
                {
                    countNumsDivBy2 += 1;
                }
                if (numsForDivide % 3 == 0)
                {
                    countNumsDivBy3 += 1;
                }
                if (numsForDivide % 4 == 0)
                {
                    countNumsDivBy4 += 1;
                }

            }

            double countNumsDivBy2InPercent = ((countNumsDivBy2 * 1.0) / numN) * 100;
            double countNumsDivBy3InPercent = ((countNumsDivBy3 * 1.0) / numN) * 100;
            double countNumsDivBy4InPercent = ((countNumsDivBy4 * 1.0) / numN) * 100;

            Console.WriteLine($"{countNumsDivBy2InPercent:F2}%");
            Console.WriteLine($"{countNumsDivBy3InPercent:F2}%");
            Console.WriteLine($"{countNumsDivBy4InPercent:F2}%");

        }
    }
}
