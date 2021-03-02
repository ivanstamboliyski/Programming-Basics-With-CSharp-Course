using System;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1111; i <= 9999; i++)
            {
                string numToText = i.ToString();

                for (int j = 0; j < numToText.Length; j++)
                {
                    int currentDigit = int.Parse(numToText[j].ToString());

                    if (currentDigit != 0)
                    {
                        if (n % currentDigit == 0)
                        {
                            counter++;

                            if (counter == 4)
                            {
                                Console.Write(i + " ");
                            }
                        }
                    }
                }
                counter = 0;
            }
        }
    }
}
