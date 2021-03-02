using System;

namespace _04.Darts_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            int succesfulShotsCouter = 0;
            int unsuccesfulShotsCouter = 0;
            int startPoints = 301;

            while (startPoints > 0)
            {
                string field = Console.ReadLine();
                if (field == "Retire")
                {
                    Console.WriteLine($"{playerName} retired after {unsuccesfulShotsCouter} unsuccessful shots.");
                    break;
                }
                int points = int.Parse(Console.ReadLine());
                succesfulShotsCouter++;

                switch (field)
                {
                    case "Single":
                        startPoints -= points;
                        if (startPoints < 0)
                        {
                            startPoints += points;
                            unsuccesfulShotsCouter++;
                            succesfulShotsCouter--;
                        }
                        break;

                    case "Double":
                        startPoints -= points * 2;
                        if (startPoints < 0)
                        {
                            startPoints += points * 2;
                            unsuccesfulShotsCouter++;
                            succesfulShotsCouter--;
                        }
                        break;

                    case "Triple":
                        startPoints -= points * 3;
                        if (startPoints < 0)
                        {
                            startPoints += points * 3;
                            unsuccesfulShotsCouter++;
                            succesfulShotsCouter--;
                        }
                        break;
                }
            }

            if (startPoints == 0)
            {
                Console.WriteLine($"{playerName} won the leg with {succesfulShotsCouter} shots.");
            }
        }
    }
}
