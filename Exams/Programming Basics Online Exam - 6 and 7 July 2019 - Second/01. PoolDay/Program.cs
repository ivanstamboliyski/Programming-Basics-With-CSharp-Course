using System;

namespace ProgrammingBasicsOnlineExam_6and7July2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double loungePrice = double.Parse(Console.ReadLine()); 
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double entranceTotalPrice = peopleCount * entranceFee;
            double umbrellaTotalPrice = Math.Ceiling(peopleCount * 1.0 / 2) * umbrellaPrice;
            double loungeTotalPrice = Math.Ceiling(peopleCount * 0.75) * loungePrice;

            double finalPrice = entranceTotalPrice + umbrellaTotalPrice + loungeTotalPrice; 

            Console.WriteLine($"{finalPrice:F2} lv.");
        }
    }
}
