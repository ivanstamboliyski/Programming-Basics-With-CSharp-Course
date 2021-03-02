using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursRequired = int.Parse(Console.ReadLine());
            int daysToCompleteProject = int.Parse(Console.ReadLine());
            int employeesOver = int.Parse(Console.ReadLine());

            double daysMinus10Percent = daysToCompleteProject * 0.9;
            double hoursToCompleteProject = daysMinus10Percent * 8;
            double overtimeHours = employeesOver * (2 * daysToCompleteProject);
            double totalHours = Math.Floor(overtimeHours + hoursToCompleteProject);

            if (totalHours >= hoursRequired)
            {
                double hoursLeft = Math.Floor(totalHours - hoursRequired);
                Console.WriteLine($"Yes!{hoursLeft} hours left."); 
            }
            else if (totalHours < hoursRequired)
            {
                double hoursNeeded = Math.Floor(hoursRequired - totalHours);
                Console.WriteLine($"Not enough time!{hoursNeeded} hours needed.");
            }
        }
    }
}
