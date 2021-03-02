using System;

namespace _04.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int stopsNumber = int.Parse(Console.ReadLine());

            for (int busStop = 1; busStop <= stopsNumber; busStop++)
            {
                int gettingOffPassengers = int.Parse(Console.ReadLine());
                int boardingPassengers = int.Parse(Console.ReadLine());

                if (busStop % 2 != 0)
                {
                    passengers += boardingPassengers + 2;
                    passengers -= gettingOffPassengers;
                }
                else
                {
                    passengers += boardingPassengers;
                    passengers -= gettingOffPassengers + 2;
                }
            }

            Console.WriteLine($"The final number of passengers is : {passengers}");
        }
    }
}
