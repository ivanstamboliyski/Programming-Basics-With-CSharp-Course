using System;

namespace _02.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipWidht = double.Parse(Console.ReadLine());
            double shipLenght = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double averageHeightCrew = double.Parse(Console.ReadLine());

            double shipVolume = shipHeight * shipLenght * shipWidht;
            double roomHeight = averageHeightCrew + 0.40;
            double roomVolume = 2 * 2 * roomHeight;
            double roomsCount = Math.Floor(shipVolume / roomVolume);

            if (roomsCount >= 3 && roomsCount <= 10)
            {
                Console.WriteLine($"The spacecraft holds {roomsCount} astronauts.");
            }
            else if (roomsCount < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
