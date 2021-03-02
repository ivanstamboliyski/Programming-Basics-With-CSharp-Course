using System;

namespace ProgrammingBasicsOnlineRetakeExam_2and3May2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegMenus = int.Parse(Console.ReadLine());

            double chickenMenusPrice = chickenMenus * 10.35;
            double fishMenusPrice = fishMenus * 12.40;
            double vegMenusPrice = vegMenus * 8.15;
            double dessert = (chickenMenusPrice + fishMenusPrice + vegMenusPrice) * 0.20;
            double delivery = 2.50;

            double totalSum = chickenMenusPrice + fishMenusPrice + vegMenusPrice + dessert + delivery;

            Console.WriteLine($"Total: {totalSum:F2}");
        }
    }
}
