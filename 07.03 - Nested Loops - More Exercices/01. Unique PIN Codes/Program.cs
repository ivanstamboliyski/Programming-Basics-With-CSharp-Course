using System;

namespace _07.NestedLoops_MoreExercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumUpperLimit = int.Parse(Console.ReadLine());
            int secondNumUpperLimit = int.Parse(Console.ReadLine());
            int thirdNumUpperLimit = int.Parse(Console.ReadLine());

            bool isPrime = true;

            for (int firstNum = 1; firstNum <= firstNumUpperLimit; firstNum++)
            {
                for (int secondNum = 2; secondNum <= secondNumUpperLimit; secondNum++)
                {
                    for (int thirdNum = 1; thirdNum <= thirdNumUpperLimit; thirdNum++)
                    {
                        isPrime = true;

                        for (int i = 2; i <= secondNum - 1; i++)
                        {
                            if (secondNum % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if (firstNum % 2 == 0 && thirdNum % 2 == 0 && isPrime)
                        {
                            Console.WriteLine($"{firstNum} {secondNum} {thirdNum} ");
                        }
                    }
                }
            }

        }
    }
}
