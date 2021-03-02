using System;

namespace _05.EasterEggs_Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggsCount = int.Parse(Console.ReadLine());
            int redEggsCounter = 0;
            int orangeEggsCounter = 0;
            int blueEggsCounter = 0;
            int greenEggsCounter = 0;

            int maxEggs = int.MinValue;
            string maxColor = "";

            for (int egg = 1; egg <= paintedEggsCount; egg++)
            {
                string eggColor = Console.ReadLine();

                switch (eggColor)
                {
                    case "red":
                        redEggsCounter++;
                        break;

                    case "orange":
                        orangeEggsCounter++;
                        break;

                    case "blue":
                        blueEggsCounter++;
                        break;

                    case "green":
                        greenEggsCounter++;
                        break;
                }

                if (redEggsCounter > maxEggs)
                {
                    maxEggs = redEggsCounter;
                    maxColor = "red";
                }
                if (orangeEggsCounter > maxEggs)
                {
                    maxEggs = orangeEggsCounter;
                    maxColor = "orange";
                }
                if (blueEggsCounter > maxEggs)
                {
                    maxEggs = blueEggsCounter;
                    maxColor = "blue";
                }
                if (greenEggsCounter > maxEggs)
                {
                    maxEggs = greenEggsCounter;
                    maxColor = "green";
                }
            }

            Console.WriteLine($"Red eggs: {redEggsCounter}");
            Console.WriteLine($"Orange eggs: {orangeEggsCounter}");
            Console.WriteLine($"Blue eggs: {blueEggsCounter}");
            Console.WriteLine($"Green eggs: {greenEggsCounter}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {maxColor}");
        }
    }
}
