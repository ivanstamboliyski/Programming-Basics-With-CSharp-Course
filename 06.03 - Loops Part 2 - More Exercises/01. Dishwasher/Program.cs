using System;

namespace _01лАсягуьягеи
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottlesDetergent = int.Parse(Console.ReadLine());

            int totalDetergent = bottlesDetergent * 750;
            int sumDishes = 0;
            int sumPots = 0;
            
            int counter = 1;

            string currInput = Console.ReadLine();

            while (currInput != "End" )
            {
                if (counter % 3 == 0)
                {
                    totalDetergent -= int.Parse(currInput) * 15;
                    sumPots += int.Parse(currInput);
                }
                else
                {
                    totalDetergent -= int.Parse(currInput) * 5;
                    sumDishes += int.Parse(currInput);
                }

                if (totalDetergent < 0)
                {
                    break;
                }
                counter++;
                currInput = Console.ReadLine();
            }

            if (totalDetergent < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(totalDetergent)} ml. more necessary!");
            }
            else
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{sumDishes} dishes and {sumPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {totalDetergent} ml.");
            }
        }
    }
}
