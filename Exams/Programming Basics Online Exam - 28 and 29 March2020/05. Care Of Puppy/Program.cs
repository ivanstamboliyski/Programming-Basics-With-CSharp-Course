using System;

namespace _05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKg = int.Parse(Console.ReadLine());
            string foodPerMealInGr = Console.ReadLine();

            int foodInGr = foodInKg * 1000;

            while (foodPerMealInGr != "Adopted")
            {
                int foodGr = int.Parse(foodPerMealInGr);

                foodInGr -= foodGr;

                foodPerMealInGr = Console.ReadLine();
            }

            if (foodInGr >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGr} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {(foodInGr * -1)} grams more.");
            }
        }
    }
}
