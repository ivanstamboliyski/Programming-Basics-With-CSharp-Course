using System;

namespace _02.LettersCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char notPrint = char.Parse(Console.ReadLine());

            int counter = 0;


            for (char firstLetter = start; firstLetter <= end; firstLetter++)
            {
                for (char secondLetter = start; secondLetter <= end; secondLetter++)
                {
                    for (char thirdLetter = start; thirdLetter <= end; thirdLetter++)
                    {
                        if (firstLetter == notPrint || secondLetter == notPrint || thirdLetter == notPrint)
                        {
                            continue;
                        }
                        else
                        {
                            counter++;
                            Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
