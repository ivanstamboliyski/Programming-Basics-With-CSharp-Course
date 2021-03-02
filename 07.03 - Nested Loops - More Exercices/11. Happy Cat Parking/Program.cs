using System;

namespace _11.HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int hoursCountPerDay = int.Parse(Console.ReadLine());

            double dailySum = 0;
            double totalSum = 0;
            int daysCounter = 0;

            for (int days = 1; days <= daysCount; days++)
            {
                daysCounter++;
                dailySum = 0;

                for (int hours = 1; hours <= hoursCountPerDay; hours++)
                {
                    if (days % 2 == 0 && hours % 2 != 0)
                    {
                        dailySum += 2.50;
                    }
                    else if (days % 2 != 0 && hours % 2 == 0)
                    {
                        dailySum += 1.25;
                    }
                    else
                    {
                        dailySum += 1.00;
                    }
                }
                Console.WriteLine($"Day: {daysCounter} - {dailySum:F2} leva");
                totalSum += dailySum;
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
