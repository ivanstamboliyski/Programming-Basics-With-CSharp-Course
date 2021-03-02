using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int operationNumbers = int.Parse(Console.ReadLine());
            int counter = 1;
            double accountBalance = 0;

            while (counter <= operationNumbers)
            {
                double currSum = double.Parse(Console.ReadLine());

                if (currSum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {currSum:F2}");
                accountBalance += currSum;
                counter++;
            }

            Console.WriteLine($"Total: {accountBalance:F2}");
        }
    }
}
