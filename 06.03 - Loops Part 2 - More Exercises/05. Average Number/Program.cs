using System;

namespace _05.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                double n2 = double.Parse(Console.ReadLine());
                sum += n2;
            }

            Console.WriteLine($"{sum / n:F2}");
        }
    }
}
