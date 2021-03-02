using System;

namespace _13.PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValueFirstPair = int.Parse(Console.ReadLine());
            int startValueSecondPair = int.Parse(Console.ReadLine());
            int differenceFirstPair = int.Parse(Console.ReadLine());
            int differenceSecondPair = int.Parse(Console.ReadLine());

            int endValueFirstPair = startValueFirstPair + differenceFirstPair;
            int endValueSecondPair = startValueSecondPair + differenceSecondPair;
            bool isPrimeFirstPair = true;
            bool isPrimeSecondPair = true;

            for (int currFirstPair = startValueFirstPair; currFirstPair <= endValueFirstPair; currFirstPair++)
            {
                for (int currSecondPair = startValueSecondPair; currSecondPair <= endValueSecondPair; currSecondPair++)
                {
                    for (int i = 2; i <= Math.Sqrt(currFirstPair); i++)
                    {
                        if (currFirstPair % i == 0)
                        {
                            isPrimeFirstPair = false;
                            break;
                        }
                        else
                        {
                            isPrimeFirstPair = true;
                        }
                    }

                    for (int j = 2; j <= Math.Sqrt(currSecondPair); j++)
                    {
                        if (currSecondPair % j == 0)
                        {
                            isPrimeSecondPair = false;
                            break;
                        }
                        else
                        {
                            isPrimeSecondPair = true;
                        }
                    }

                    if (isPrimeFirstPair && isPrimeSecondPair)
                    {
                        Console.WriteLine($"{currFirstPair}{currSecondPair}");
                    }
                }
            }
        }
    }
}
