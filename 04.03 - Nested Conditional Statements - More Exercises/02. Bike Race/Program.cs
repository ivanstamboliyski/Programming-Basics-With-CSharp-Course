using System;

namespace _02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberJuniorsBikers = int.Parse(Console.ReadLine());
            int numberSeniorsBikers = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();

            double feeJuniorsBikers = 0;
            double feeSeniorsBikers = 0;


            switch (track)
            {
                case "trail":
                    feeJuniorsBikers = 5.50;
                    feeSeniorsBikers = 7.00;
                    break;

                case "cross-country":
                    feeJuniorsBikers = 8.00;
                    feeSeniorsBikers = 9.50;
                    if ((numberJuniorsBikers + numberSeniorsBikers) >= 50)
                    {
                        feeJuniorsBikers = 8.00 * 0.75;
                        feeSeniorsBikers = 9.50 * 0.75;
                    }
                    break;

                case "downhill":
                    feeJuniorsBikers = 12.25;
                    feeSeniorsBikers = 13.75;
                    break;

                case "road":
                    feeJuniorsBikers = 20;
                    feeSeniorsBikers = 21.50;
                    break;
            }

            double sum = (feeJuniorsBikers * numberJuniorsBikers) + (feeSeniorsBikers * numberSeniorsBikers);
            double finalSum = sum * 0.95;

            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
