using System;

namespace _06.HighJump_Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int desiredHeigh = int.Parse(Console.ReadLine());

            int attemptsCounter = 0;
            int lastHeigh = 0;
            int failCounter = 0;
            bool hasToEnd = false;

            for (int attempts = desiredHeigh - 30; attempts <= desiredHeigh; attempts += 5)
            {
                int currHeigh = int.Parse(Console.ReadLine());
                attemptsCounter++;
                lastHeigh = attempts;

                if (currHeigh > attempts)
                {
                    continue;
                }
                else
                {
                    failCounter++;
                    while (failCounter < 3)
                    {
                        currHeigh = int.Parse(Console.ReadLine());
                        attemptsCounter++;
                        if (currHeigh <= attempts)
                        {
                            failCounter++;
                        }
                        else
                        {
                            failCounter = 0;
                            break;
                        }
                    }
                }

                if (failCounter == 3)
                {
                    hasToEnd = true;
                    break;
                }
            }

            if (hasToEnd)
            {
                Console.WriteLine($"Tihomir failed at {lastHeigh}cm after {attemptsCounter} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {desiredHeigh}cm after {attemptsCounter} jumps.");
            }
        }
    }
}
