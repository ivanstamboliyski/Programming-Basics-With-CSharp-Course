using System;

namespace _06.TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            double maxSum = int.MinValue;
            string winnerWord = "";

            while (word != "End of words")
            {
                int wordLenght = word.Length;
                double currSum = 0;
                char firstChar = word[0];

                for (int symbol = 0; symbol < wordLenght; symbol++)
                {
                    char currSymbol = word[symbol];
                    currSum += (int)currSymbol;
                }

                if (firstChar == 'a' || firstChar == 'e'|| firstChar == 'i' || firstChar == 'o' || firstChar == 'u' || firstChar == 'y' || firstChar == 'A' || firstChar == 'E' || firstChar == 'I' || firstChar == 'O' || firstChar == 'U' || firstChar == 'Y')
                {
                    currSum = currSum * wordLenght;
                }
                else
                {
                    currSum = Math.Floor(currSum / wordLenght);
                }

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    winnerWord = word;
                }
                word = Console.ReadLine();
            }

            Console.WriteLine($"The most powerful word is {winnerWord} - {maxSum}");
        }
    }
}
