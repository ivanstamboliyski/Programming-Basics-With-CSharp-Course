using System;

namespace _05.EasterBake_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreadCount = int.Parse(Console.ReadLine());

            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;
            int totalSugar = 0;
            int totalFlour = 0;

            for (int easterBreads = 1; easterBreads <= easterBreadCount; easterBreads++)
            {
                int quantitySugar = int.Parse(Console.ReadLine());
                int quantityFlour = int.Parse(Console.ReadLine());

                totalSugar += quantitySugar;
                totalFlour += quantityFlour;

                if (quantitySugar > maxSugar)
                {
                    maxSugar = quantitySugar;
                }
                if (quantityFlour > maxFlour)
                {
                    maxFlour = quantityFlour;
                }
            }

            double neededPackageSugar = Math.Ceiling(totalSugar * 1.0 / 950);
            double neededPackageFlour = Math.Ceiling(totalFlour * 1.0 / 750);

            Console.WriteLine($"Sugar: {neededPackageSugar}");
            Console.WriteLine($"Flour: {neededPackageFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
