using System;

namespace _10.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidaysInYear = int.Parse(Console.ReadLine());
            int weekendsHomeTown = int.Parse(Console.ReadLine());

            double playsInSofia = (48.0 - weekendsHomeTown) * 3/4;
            double playsInHolidays = (holidaysInYear * 1.0) * 2 / 3;
            double playsInHomeTown = weekendsHomeTown;

            if (yearType == "normal")
            {
                double totalPlays = playsInSofia + playsInHolidays + playsInHomeTown;
                Console.WriteLine(Math.Floor(totalPlays));
            }
            else if (yearType == "leap")
            {
                double totalPlays = (playsInSofia + playsInHolidays + playsInHomeTown) * 1.15;
                Console.WriteLine(Math.Floor(totalPlays));
            }

        } 
    }
}
