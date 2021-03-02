using System;

namespace _04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double allFood = double.Parse(Console.ReadLine());

            int totalDogFood = 0;
            int totalCatFood = 0;
            double biscuits = 0;

            for (int day = 1; day <= days; day++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());
                if (day % 3 == 0)
                {
                    biscuits += (dogFood + catFood) * 0.10;
                }
                totalDogFood += dogFood;
                totalCatFood += catFood;
            }

            int totalFood = totalCatFood + totalDogFood;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{totalFood * 1.0 / allFood * 100:F2}% of the food has been eaten.");
            Console.WriteLine($"{totalDogFood * 1.0 / totalFood * 100:F2}% eaten from the dog.");
            Console.WriteLine($"{totalCatFood * 1.0 / totalFood * 100:F2}% eaten from the cat.");
        }
    }
}
