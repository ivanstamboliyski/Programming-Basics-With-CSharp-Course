using System;

namespace _05.ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int mensCount = int.Parse(Console.ReadLine());
            int womensCount = int.Parse(Console.ReadLine());
            int tablesMaxCount = int.Parse(Console.ReadLine());

            int tablesCounter = 0;
            bool hasToEnd = false;

            for (int mens = 1; mens <= mensCount; mens++)
            {
                for (int womens = 1; womens <= womensCount; womens++)
                {
                    Console.Write($"({mens} <-> {womens}) ");

                    tablesCounter++;

                    if (tablesCounter == tablesMaxCount)
                    {
                        hasToEnd = true;
                        break;
                    }
                }
                if (hasToEnd)
                {
                    break;
                }
            }
        }
    }
}
