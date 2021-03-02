using System;

namespace _01.MovieProfit_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());
            int ticketsCount = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int cinemaPercent = int.Parse(Console.ReadLine());

            double income = daysCount * ticketsCount * ticketPrice;
            double percent = income * cinemaPercent / 100;
            income -= percent;

            Console.WriteLine($"The profit from the movie {movieName} is {income:F2} lv.");
        }
    }
}
