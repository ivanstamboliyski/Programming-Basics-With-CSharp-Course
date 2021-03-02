using System;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int treatedPatiens = 0;
            int untreatedPatiens = 0;
            int doctors = 7;

            for (int i = 1; i <= period; i++)
            {
                int currentPatiens = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && untreatedPatiens > treatedPatiens)
                {
                    doctors++;
                }
                if (currentPatiens > doctors)
                {
                    treatedPatiens += doctors;
                    untreatedPatiens += currentPatiens - doctors;
                }
                else
                {
                    treatedPatiens += currentPatiens;
                }
                
            }

            Console.WriteLine($"Treated patients: {treatedPatiens}.");
            Console.WriteLine($"Untreated patients: {untreatedPatiens}.");
        }
    }
}
