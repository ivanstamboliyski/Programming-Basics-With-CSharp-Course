using System;

namespace _02.EasterParty_Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            double foodPricePerPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (guestsCount >= 10 && guestsCount <= 15)
            {
                foodPricePerPerson *= 0.85;
            }
            else if (guestsCount > 15 && guestsCount <= 20)
            {
                foodPricePerPerson *= 0.80;
            }
            else if (guestsCount > 20)
            {
                foodPricePerPerson *= 0.75;
            }

            double neededSum = guestsCount * foodPricePerPerson + budget * 0.10;

            if (budget >= neededSum)
            {
                Console.WriteLine($"It is party time! {budget - neededSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {neededSum - budget:F2} leva needed.");
            }
        }
    }
}
