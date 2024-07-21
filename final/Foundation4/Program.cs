using System;
using System.Runtime.InteropServices.Marshalling;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        List<Actvitys> activities = new List<Actvitys>();
        SwimmingActvity swimming = new SwimmingActvity("Aug 1st, 2023", 30, 30);
        activities.Add(swimming);

        foreach (Actvitys actvity in activities)
        {
            Console.WriteLine();
            actvity.ActvitySummary();
        }

    }
}