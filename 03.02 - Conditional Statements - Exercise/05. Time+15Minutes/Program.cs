using System;

namespace _05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMinutes = hour * 60 + minutes;
            int timeInMinutsAfter15Min = timeInMinutes + 15;
            int hoursAfter15Min = timeInMinutsAfter15Min / 60;
            int minutesAfter15Min = timeInMinutsAfter15Min % 60;

            if (hoursAfter15Min == 24)
            {
                hoursAfter15Min = 0;
            }

            Console.WriteLine($"{hoursAfter15Min}:{minutesAfter15Min:D2}");
        }
    }
}
