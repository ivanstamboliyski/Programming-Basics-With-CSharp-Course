using System;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numN = int.Parse(Console.ReadLine());

            int firstNumsCount = 0;
            int secondNumsCount = 0;
            int thirdNumsCount = 0;
            int fourthNumsCount = 0;
            int fivethNumsCount = 0;

            for (int i = 1; i <= numN; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    firstNumsCount++; 
                }
                else if (num >= 200 && num < 400)
                {
                    secondNumsCount++;
                }
                else if (num >= 400 && num < 600)
                {
                    thirdNumsCount++;
                }
                else if (num >=600 && num < 800)
                {
                    fourthNumsCount++;
                }
                else
                {
                    fivethNumsCount++;
                }
            }

            double firstGroupPercent = (firstNumsCount * 1.0) / numN * 100;
            double secondGroupPercent = (secondNumsCount * 1.0) / numN * 100;
            double thirdGroupPercent = (thirdNumsCount * 1.0) / numN * 100;
            double fourthGroupPercent = (fourthNumsCount * 1.0) / numN * 100;
            double fivethGroupPercent = (fivethNumsCount * 1.0) / numN * 100;

            Console.WriteLine($"{firstGroupPercent:F2}%");
            Console.WriteLine($"{secondGroupPercent:F2}%");
            Console.WriteLine($"{thirdGroupPercent:F2}%");
            Console.WriteLine($"{fourthGroupPercent:F2}%");
            Console.WriteLine($"{fivethGroupPercent:F2}%");
        }
    }
}
