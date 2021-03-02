using System;

namespace _09.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;
            bool hasToEnd = false;

            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    counter++;
                     sum = num1 + num2;

                    if (sum == magicalNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {magicalNum})");
                        hasToEnd = true;
                        break;
                    }
                }
                if (hasToEnd)
                {
                    break;
                }
            }

            if (!hasToEnd)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNum}");
            }
        }
    }
}
