using System;

namespace _05.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Input : lenght hall in meters (double), wight hall in meters (double), side A of wardrobe in meters(double).
            // 2. Calculate area of the hall, calculate area of the wardrobe, calculate area of the bench.
            // 3. Calculate usable space of the hall in meters.
            // 4. Input :space for one dancer and needed space for dancing for one dancer in centimeters converted to meters.
            // 5. Calculate how many dancers can dance into to usable space.

            double lenght = double.Parse(Console.ReadLine());
            double wight = double.Parse(Console.ReadLine());
            double sideWardrobe = double.Parse(Console.ReadLine());

            double hallArea = lenght * wight;
            double wardrobeArea = sideWardrobe * sideWardrobe;
            double benchArea = hallArea / 10;

            double usableSpace = hallArea - wardrobeArea - benchArea;

            double spaceOneDancer = (40 + 7000) * 0.0001;

            double howManyDancers = usableSpace / spaceOneDancer;

            Console.WriteLine(Math.Floor(howManyDancers));



        }
    }
}
