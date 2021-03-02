using System;

namespace _03.PaintingEggs_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggsSize = Console.ReadLine();
            string eggsColor = Console.ReadLine();
            int batchesCount = int.Parse(Console.ReadLine());

            int batchPrice = 0;

            if (eggsSize == "Large")
            {
                if (eggsColor == "Red")
                {
                    batchPrice = 16;
                }
                else if (eggsColor == "Green")
                {
                    batchPrice = 12;
                }
                else
                {
                    batchPrice = 9;
                }
            }
            else if (eggsSize == "Medium")
            {
                if (eggsColor == "Red")
                {
                    batchPrice = 13;
                }
                else if (eggsColor == "Green")
                {
                    batchPrice = 9;
                }
                else
                {
                    batchPrice = 7;
                }
            }
            else
            {
                if (eggsColor == "Red")
                {
                    batchPrice = 9;
                }
                else if (eggsColor == "Green")
                {
                    batchPrice = 8;
                }
                else
                {
                    batchPrice = 5;
                }
            }

            int allBatchesPrice = batchesCount * batchPrice;
            double finalPrice = allBatchesPrice * 0.65;

            Console.WriteLine($"{finalPrice:F2} leva.");
        }
    }
}
