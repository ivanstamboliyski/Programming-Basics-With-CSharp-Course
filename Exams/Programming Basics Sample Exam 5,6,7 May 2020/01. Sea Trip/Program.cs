using System;

namespace ProgrammingBasicsSampleExam5_6_7May2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodMoney = double.Parse(Console.ReadLine());
            double souvenirsMoney = double.Parse(Console.ReadLine());
            double hotelMoney = double.Parse(Console.ReadLine());

            double fuelPrice = 4.2 * 7 * 1.85;
            double souvenirsPrice = souvenirsMoney * 3;
            double hotelPrice = hotelMoney * 0.90 + hotelMoney * 0.85 + hotelMoney * 0.80;
            double foodPrice = foodMoney * 3;

            double totalPrice = fuelPrice + souvenirsPrice + hotelPrice + foodPrice;

            Console.WriteLine($"Money needed: {totalPrice:F2}");
            

        }
    }
}
