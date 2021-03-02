using System;

namespace _02.YoungCapitalist
{
    class Program
    {
        static void Main(string[] args)
        {
            double parentsMoney = double.Parse(Console.ReadLine());
            int invited = int.Parse(Console.ReadLine());
            double singleChildMoney = double.Parse(Console.ReadLine());
            double scooterPrice = double.Parse(Console.ReadLine());

            double willCome = Math.Ceiling(invited * 0.85);
            double moneyGift = Math.Floor(willCome * 0.80);
            double restaurant = willCome * 4.50;

            double income = parentsMoney + (moneyGift * singleChildMoney) - restaurant;
            double scooterDelivery = scooterPrice * 0.05;
            double finalSum = income - scooterDelivery;

            if (finalSum >= scooterPrice)
            {
                Console.WriteLine("Asparuh will be driving a fast 49cc Scooter soon.");
                Console.WriteLine($"Money left: {finalSum - scooterPrice:F2} BGN");
            }
            else
            {
                Console.WriteLine($"If only Asparuh had {scooterPrice - finalSum:F2} BGN more...");
                Console.WriteLine("Guess he will be walking for now.");
            }
        }
    }
}
