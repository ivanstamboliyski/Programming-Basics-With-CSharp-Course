using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int primeNumbersSum = 0;
            int nonPrimeNumbersSum = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                bool isPrime = true;

                for (int i = 2; i <= number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && number > 1)
                {
                    primeNumbersSum += number;
                }
                else if (!isPrime && number > 1)
                {
                    nonPrimeNumbersSum += number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbersSum}");
          
        }
    }
}
