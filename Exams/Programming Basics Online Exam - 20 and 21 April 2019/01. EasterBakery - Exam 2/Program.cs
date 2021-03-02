using System;

namespace _01.EasterBakery_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPricePerKg = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            int eggsBoxesCount = int.Parse(Console.ReadLine());
            int yeastBoxesCount = int.Parse(Console.ReadLine());

            double sugarPricePerKg = flourPricePerKg * 0.75;
            double sugarPrice = sugarPricePerKg * sugarKg;
            double eggsBoxesPrice = flourPricePerKg * 1.10;
            double eggsPrice = eggsBoxesPrice * eggsBoxesCount;
            double yeastBoxPrice = sugarPricePerKg * 0.20;
            double yeastPrice = yeastBoxPrice * yeastBoxesCount;
            double flourPrice = flourPricePerKg * flourKg;

            double totalPrice = sugarPrice + eggsPrice + yeastPrice + flourPrice;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
