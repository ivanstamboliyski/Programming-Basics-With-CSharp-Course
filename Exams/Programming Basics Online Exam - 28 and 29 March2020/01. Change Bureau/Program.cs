using System;

namespace ProgrammingBasicsOnlineExam_28and29March2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoinsCount = int.Parse(Console.ReadLine());
            double yuansCount = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double bitcoinsInLeva = bitcoinsCount * 1168;
            double yuansInDollars = yuansCount * 0.15;
            double yuansInLeva = yuansInDollars * 1.76;
            double euro = (bitcoinsInLeva + yuansInLeva) / 1.95;
            
            double finalSum = euro - (commission / 100 * euro);

            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
