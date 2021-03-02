using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            int foodInKg = int.Parse(Console.ReadLine());
            double foodPerDogInKg = double.Parse(Console.ReadLine());
            double foodPerCatInKg = double.Parse(Console.ReadLine());
            double foodPerTurtleInG = double.Parse(Console.ReadLine());

            double foodPerTurtleInKg = foodPerTurtleInG / 1000;
            double totalFood = (foodPerDogInKg + foodPerCatInKg + foodPerTurtleInKg) * countDays;

            if (foodInKg >= totalFood)
            {
                double foodLeft = Math.Floor(foodInKg - totalFood);
                Console.WriteLine($"{foodLeft} kilos of food left.");
            }
            else if (foodInKg < totalFood)
            {
                double foodNeeded = Math.Ceiling(totalFood - foodInKg);
                Console.WriteLine($"{foodNeeded} more kilos of food are needed.");
            }
        }
    }
}
