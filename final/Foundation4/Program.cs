using System;
using System.Runtime.InteropServices.Marshalling;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        List<Actvitys> activities = new List<Actvitys>();
        SwimmingActvity swimming = new SwimmingActvity("1st July, 2024", 30, 50);
        activities.Add(swimming);

        RunningActvity running = new RunningActvity("4th July, 2024", 120, 13.7);
        activities.Add(running);

        CyclingActvity cycling = new CyclingActvity("15th July, 2024", 90, 12.2);
        activities.Add(cycling);

        foreach (Actvitys actvity in activities)
        {
            actvity.ActvitySummary();
            Console.WriteLine();
        }

    }
}