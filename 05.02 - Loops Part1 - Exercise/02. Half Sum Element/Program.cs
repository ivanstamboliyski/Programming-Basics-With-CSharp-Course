using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numN = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int sumAllNums = 0;

            for (int i = 1; i <= numN; i++)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (currNum > maxNum)
                {
                    maxNum = currNum;
                }

                sumAllNums += currNum;
            }

            int sum = sumAllNums - maxNum;

            if (maxNum == sum )
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(maxNum - sum));
            }
        }
    }
}
