using System;

namespace _02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int walkMinuts = int.Parse(Console.ReadLine()); 
            int walkCount = int.Parse(Console.ReadLine()); 
            int dayCalories = int.Parse(Console.ReadLine());

            int totalWalkMinuts = walkMinuts * walkCount;
            int burnedCalories = totalWalkMinuts * 5;

            if (burnedCalories >= (dayCalories * 0.50))
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
