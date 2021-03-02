using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numN = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numN; i++)
            {
                int currN = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currN;
                }
                else
                {
                    oddSum += currN;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(evenSum - oddSum));
            }

          
        }
    }
}
