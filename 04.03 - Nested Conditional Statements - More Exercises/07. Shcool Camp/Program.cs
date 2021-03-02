using System;

namespace _07.ShcoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsNumber = int.Parse(Console.ReadLine());
            int nightsNumber = int.Parse(Console.ReadLine());

            double pricePerNight = 0;

            if (groupType == "boys" || groupType == "girls")
            {
                if (season == "Winter")
                {
                    pricePerNight = 9.60;
                }
                else if (season == "Spring")
                {
                    pricePerNight = 7.20;
                }
                else if (season == "Summer")
                {
                    pricePerNight = 15;
                }
            }
            else if (groupType == "mixed")
            {
                if (season == "Winter")
                {
                    pricePerNight = 10;
                }
                else if (season == "Spring")
                {
                    pricePerNight = 9.50;
                }
                else if (season == "Summer")
                {
                    pricePerNight = 20;
                }
            }

            double totalPrice = studentsNumber * nightsNumber * pricePerNight;

            if (studentsNumber >= 50)
            {
                totalPrice *= 0.50;
            }
            else if (studentsNumber >= 20 && studentsNumber < 50)
            {
                totalPrice *= 0.85;
            }
            else if (studentsNumber >= 10 && studentsNumber < 20)
            {
                totalPrice *= 0.95;
            }

            string sport = "";

            if (groupType == "girls")
            {
                if (season == "Winter")
                {
                    sport = "Gymnastics";
                }
                else if (season == "Spring")
                {
                    sport = "Athletics";
                }
                else if (season == "Summer")
                {
                    sport = "Volleyball";
                }
            }
            else if (groupType == "boys")
            {
                if (season == "Winter")
                {
                    sport = "Judo";
                }
                else if (season == "Spring")
                {
                    sport = "Tennis";
                }
                else if (season == "Summer")
                {
                    sport = "Football";
                }
            }
            else if (groupType == "mixed")
            {
                if (season == "Winter")
                {
                    sport = "Ski";
                }
                else if (season == "Spring")
                {
                    sport = "Cycling";
                }
                else if (season == "Summer")
                {
                    sport = "Swimming";
                }
            }

            Console.WriteLine($"{sport} {totalPrice:F2} lv.");

        }
    }
}
