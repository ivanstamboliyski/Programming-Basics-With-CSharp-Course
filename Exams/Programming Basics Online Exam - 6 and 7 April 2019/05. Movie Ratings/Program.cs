using System;

namespace _05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int moviesCount = int.Parse(Console.ReadLine());

            double maxRating = double.MinValue;
            string movieMaxRating = "";
            double minRating = double.MaxValue;
            string movieMinRating = "";
            double sumRaitings = 0;

            for (int currMovie = 1; currMovie <= moviesCount; currMovie++)
            {
                string movieName = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                sumRaitings += rating;

                if (rating > maxRating)
                {
                    movieMaxRating = movieName;
                    maxRating = rating;
                }
                if (rating < minRating)
                {
                    movieMinRating = movieName;
                    minRating = rating;
                }
            }

            Console.WriteLine($"{movieMaxRating} is with highest rating: {maxRating:F1}");
            Console.WriteLine($"{movieMinRating} is with lowest rating: {minRating:F1}");
            Console.WriteLine($"Average rating: {sumRaitings / moviesCount:F1}");
        }
    }
}
