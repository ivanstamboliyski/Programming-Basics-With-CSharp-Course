using System;

namespace _02.BeehiveRole
{
    class Program
    {
        static void Main(string[] args)
        {
            int intellect = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            string beeRole = "";

            if (intellect >= 80 && power >= 80 && gender == "female")
            {
                beeRole = "Queen Bee";
            }
            else if (intellect >= 80)
            {
                beeRole = "Repairing Bee";
            }
            else if (intellect >= 60)
            {
                beeRole = "Cleaning Bee";
            }
            else if (power >= 80 && gender == "male")
            {
                beeRole = "Drone Bee";
            }
            else if (power >= 60)
            {
                beeRole = "Guard Bee";
            }
            else
            {
                beeRole = "Worker Bee"; 
            }

            Console.WriteLine(beeRole);
        }
    }
}
