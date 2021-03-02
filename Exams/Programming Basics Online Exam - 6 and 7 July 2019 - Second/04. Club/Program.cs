using System;

namespace _04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredProfit = double.Parse(Console.ReadLine());
            string cocktailName = Console.ReadLine();

            double profit = 0;
            double currOrderPrice = 0;

            while (cocktailName != "Party!")
            {
                int cocktailCount = int.Parse(Console.ReadLine());
                double cocktailPrice = cocktailName.Length;
                currOrderPrice = cocktailCount * cocktailPrice;

                if (currOrderPrice % 2 != 0)
                {
                    currOrderPrice *= 0.75;
                }
                profit += currOrderPrice;
                
                if (profit >= desiredProfit)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }
                cocktailName = Console.ReadLine();
            }

            if (cocktailName == "Party!")
            {
                Console.WriteLine($"We need {desiredProfit - profit:F2} leva more.");
            }
            Console.WriteLine($"Club income - {profit:F2} leva.");
        }
    }
}
