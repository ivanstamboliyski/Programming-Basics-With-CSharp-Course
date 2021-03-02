using System;

namespace _01.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonSize = int.Parse(Console.ReadLine());
            int paintLitters = int.Parse(Console.ReadLine());
            int diluentLitters = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());

            double diluentPrice = diluentLitters * 5;
            double bagsPrice = 0.40;
            double nylonPrice = (nylonSize + 2) * 1.50;
            double paintPrice = (paintLitters + (paintLitters * 0.10)) * 14.50;
            double pricePerWorkHour = (bagsPrice + nylonPrice + paintPrice + diluentPrice) * 0.30;
            double workingHoursPrice = pricePerWorkHour * workingHours;
            double totalExpenses = bagsPrice + nylonPrice + paintPrice + workingHoursPrice + diluentPrice;

            Console.WriteLine($"Total expenses: {totalExpenses:F2} lv.");
        }
    }
}
