using System;

namespace _05.FitnessCenter_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitorsCount = int.Parse(Console.ReadLine());

            int backCounter = 0;
            int chestCounter = 0;
            int legsCounter = 0;
            int absCounter = 0;
            int shakeCounter = 0;
            int barCounter = 0;

            for (int visitor = 1; visitor <= visitorsCount; visitor++)
            {
                string activity = Console.ReadLine();

                switch (activity)
                {
                    case "Back":
                        backCounter++;
                        break;

                    case "Chest":
                        chestCounter++;
                        break;

                    case "Legs":
                        legsCounter++;
                        break;

                    case "Abs":
                        absCounter++;
                        break;

                    case "Protein shake":
                        shakeCounter++;
                        break;

                    case "Protein bar":
                        barCounter++;
                        break;
                }
            }

            Console.WriteLine($"{backCounter} - back");
            Console.WriteLine($"{chestCounter} - chest");
            Console.WriteLine($"{legsCounter} - legs");
            Console.WriteLine($"{absCounter} - abs");
            Console.WriteLine($"{shakeCounter} - protein shake");
            Console.WriteLine($"{barCounter} - protein bar");
            Console.WriteLine($"{(backCounter * 1.0 + chestCounter * 1.0 + legsCounter * 1.0 + absCounter * 1.0) / visitorsCount * 100:F2}% - work out");
            Console.WriteLine($"{(shakeCounter * 1.0 + barCounter * 1.0) / visitorsCount * 100:F2}% - protein");
        }
    }
}
