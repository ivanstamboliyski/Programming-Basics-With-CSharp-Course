using System;

namespace _08.SecretDoorsLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumLimit = int.Parse(Console.ReadLine());
            int secondNumLimit = int.Parse(Console.ReadLine());
            int thirdNumLimit = int.Parse(Console.ReadLine());

            bool isPrime = true;

            for (int num1 = 1; num1 <= firstNumLimit; num1++)
            {
                for (int num2 = 2; num2 <= secondNumLimit; num2++)
                {
                    for (int num3 = 1; num3 <= thirdNumLimit; num3++)
                    {
                        isPrime = true;

                        for (int i = 2; i <= num2 - 1; i++)
                        {
                            if (num2 % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if (num1 % 2 == 0 && num3 % 2 == 0 && isPrime)
                        {
                            Console.WriteLine($"{num1} {num2} {num3}");
                        }
                    }
                }
            }
        }
    }
}
