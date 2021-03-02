using System;

namespace _02.EasterGuests_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double kozunaksCount = Math.Ceiling(guestsCount * 1.0 / 3);
            double kozunzksPrice = kozunaksCount * 4;
            double eggsCount = guestsCount * 2;
            double eggsPrice = eggsCount * 0.45;
            double finalPrice = eggsPrice + kozunzksPrice;

            if (budget >= finalPrice)
            {
                Console.WriteLine($"Lyubo bought {kozunaksCount} Easter bread and {eggsCount} eggs.");
                Console.WriteLine($"He has {budget - finalPrice:F2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {finalPrice - budget:F2} lv. more.");
            }

        }
    }
}
