using System;

namespace _08.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litters = double.Parse(Console.ReadLine());

            string fuelLower = fuel.ToLower();

            if (fuel != "Diesel" && fuel != "Gasoline" && fuel != "Gas")
            {
                Console.WriteLine("Invalid fuel!");
            }
            else if (litters >= 25)
            {
                Console.WriteLine($"You have enough {fuelLower}.");
            }
            else if (litters < 25)
            {
                Console.WriteLine($"Fill your tank with {fuelLower}!");
            }
 
        }
    }
}
