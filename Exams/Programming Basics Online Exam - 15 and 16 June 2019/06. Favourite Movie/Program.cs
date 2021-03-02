using System;

namespace _06.FavouriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();


            int maxPoints = int.MinValue;
            string winner = "";
            int movieCounter = 0; 

            while (movieName != "STOP")
            {
                int moviePoints = movieName.Length;
                movieCounter++;
                if (movieCounter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }

                int currMoviePoints = 0;

                for (int movie = 0; movie < moviePoints; movie++)
                {
                    char currDigit = movieName[movie];
                    currMoviePoints += (int)currDigit;

                    if (currDigit >= 'a' && currDigit <= 'z')
                    {
                        currMoviePoints -= 2 * moviePoints;
                    }
                    if (currDigit >= 'A' && currDigit <= 'Z')
                    {
                        currMoviePoints -= moviePoints;
                    }
                }

                if (currMoviePoints > maxPoints)
                {
                    maxPoints = currMoviePoints;
                    winner = movieName;
                }

                movieName = Console.ReadLine();
            }

            Console.WriteLine($"The best movie for you is {winner} with {maxPoints} ASCII sum.");
        }
    }
}
