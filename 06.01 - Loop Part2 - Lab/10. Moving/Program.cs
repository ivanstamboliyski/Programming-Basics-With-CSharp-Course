using System;

namespace _10.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widhtAvailableSpace = int.Parse(Console.ReadLine());
            int lenghtAvailableSpace = int.Parse(Console.ReadLine());
            int heightAvailableSpace = int.Parse(Console.ReadLine());

            int availableSpace = widhtAvailableSpace * lenghtAvailableSpace * heightAvailableSpace;
            int sumBoxes = 0;

            string numberBoxes = Console.ReadLine();

            while (numberBoxes != "Done")
            {
                sumBoxes += int.Parse(numberBoxes);

                if (sumBoxes >= availableSpace)
                {
                    break;
                }

                numberBoxes = Console.ReadLine();
            }

            if (numberBoxes == "Done")
            {
                Console.WriteLine($"{availableSpace - sumBoxes} Cubic meters left.");
            }
            else 
            {
                Console.WriteLine($"No more free space! You need {sumBoxes - availableSpace} Cubic meters more.");
            }
        }
    }
}
