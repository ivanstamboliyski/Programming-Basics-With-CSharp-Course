using System;

namespace _05.BarchelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestPerformerSum = int.Parse(Console.ReadLine());

            string groups = Console.ReadLine();
            int income = 0;
            int guestsCount = 0;

            while (groups != "The restaurant is full")
            {
                int groupCount = int.Parse(groups);

                guestsCount += groupCount;

                if (groupCount < 5)
                {
                    income += groupCount * 100;
                }
                else
                {
                    income += groupCount * 70;
                }

                groups = Console.ReadLine();
            }

            if (income >= guestPerformerSum)
            {
                Console.WriteLine($"You have {guestsCount} guests and {income - guestPerformerSum} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {guestsCount} guests and {income} leva income, but no singer.");
            }
        }
    }
}
