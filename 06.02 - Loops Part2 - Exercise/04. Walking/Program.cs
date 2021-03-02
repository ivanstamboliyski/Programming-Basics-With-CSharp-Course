using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sumSteps = 0;
            int goal = 10000;

            while (sumSteps < goal)
            {
                if (command == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    sumSteps += stepsToHome;
                    break;
                }
                sumSteps += int.Parse(command);
                command = Console.ReadLine();
            }

            if ( sumSteps < goal)
            {
                Console.WriteLine($"{goal - sumSteps} more steps to reach goal.");
            }
            else 
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            
        }
    }
}
