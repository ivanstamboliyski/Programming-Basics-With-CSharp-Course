using System;

namespace _01.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int packsPensCount = int.Parse(Console.ReadLine());
            int packsMarkersCount = int.Parse(Console.ReadLine());
            double cleaningDetergent = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double packsPensPrice = packsPensCount * 5.80;
            double packsMarkersPrice = packsMarkersCount * 7.20;
            double cleaningDetergentPrice = cleaningDetergent * 1.20;

            double totalPrice = packsPensPrice + packsMarkersPrice + cleaningDetergentPrice;
            double discountInLv = totalPrice * discount / 100;
            double finalPrice = totalPrice - discountInLv;

            Console.WriteLine($"{finalPrice:F3}");
        }
    }
}
