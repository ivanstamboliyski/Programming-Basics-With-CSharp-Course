using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int counter = 0;

            while (counter < nNumbers)
            {
                int n = int.Parse(Console.ReadLine());

                if (n > maxNumber)
                {
                    maxNumber = n;
                }
                counter++;
            }

            Console.WriteLine(maxNumber);
        }
    }
}
