using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;
            int counter = 0;

            while (counter < nNumbers)
            {
                int n = int.Parse(Console.ReadLine());

                if (n < minNumber)
                {
                    minNumber = n;
                }
                counter++;
            }

            Console.WriteLine(minNumber);
        }
    }
}
