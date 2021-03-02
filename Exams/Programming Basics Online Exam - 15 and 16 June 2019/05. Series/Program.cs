using System;

namespace _05.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int serialsCount = int.Parse(Console.ReadLine());

            double spentSum = 0;

            for (int serial = 1; serial <= serialsCount; serial++)
            {
                string serialName = Console.ReadLine();
                double serialPrice = double.Parse(Console.ReadLine());

                if (serialName == "Thrones")
                {
                    serialPrice *= 0.50;
                }
                else if (serialName == "Lucifer")
                {
                    serialPrice *= 0.60;
                }
                else if (serialName == "Protector")
                {
                    serialPrice *= 0.70;
                }
                else if (serialName == "TotalDrama")
                {
                    serialPrice *= 0.80;
                }
                else if (serialName == "Area")
                {
                    serialPrice *= 0.90;
                }
                spentSum += serialPrice;
            }

            if (budget >= spentSum)
            {
                Console.WriteLine($"You bought all the series and left with {budget - spentSum:F2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {spentSum - budget:F2} lv. more to buy the series!");
            }


        }
    }
}
