using System;

namespace PBSchoolPracticalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double startCapital = double.Parse(Console.ReadLine());
            double endCapital = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double profit = endCapital - startCapital;
            double reInvested1 = profit * 0.40;
            double reInvested2 = reInvested1 * 0.50;
            double pureProfit = profit - reInvested1 - reInvested2;
            double taxes = pureProfit * tax / 100;
            double finalCapital = startCapital + pureProfit - taxes;

            Console.WriteLine($"Capital at the end of the year: EUR {finalCapital:F2}");
            Console.WriteLine($"Taxes Paid: EUR {taxes:F2}");
        }
    }
}
