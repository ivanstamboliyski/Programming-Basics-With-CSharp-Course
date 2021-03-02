using System;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double littersFuelNeeded = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double littersPrice = littersFuelNeeded * 2.10;
            int guide = 100;

            double totalPrice = littersPrice + guide;

            if (day == "Saturday")
            {
                totalPrice *= 0.90;
            }
            else
            {
                totalPrice *= 0.80;
            }

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Safari time! Money left: {budget - totalPrice:f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {totalPrice - budget:F2} lv.");
            }
        }
    }
}
