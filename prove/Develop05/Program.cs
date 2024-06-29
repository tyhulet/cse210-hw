using System;

class Program
{
    static void Main(string[] args)
    {
        var choice = "";
        do
        {
            GoalTracker goal = new GoalTracker();
            goal.ShowUserInfo();
            Console.WriteLine("Goal Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Please Enter your choice: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                GoalTracker goalTracker = new GoalTracker();
                goalTracker.AddGoals();
            }
            else if (choice == "2")
            {
                GoalTracker goalTracker = new GoalTracker();
                goalTracker.ShowGoals(); goalTracker.ShowGoalsDetails();
            }
            else if (choice == "3")
            {
                GoalTracker goalTracker = new GoalTracker();
                goalTracker.SaveFile();
            }
            else if (choice == "4")
            {
                GoalTracker goalTracker = new GoalTracker();
                goalTracker.LoadFile();
            }
            else if (choice == "5")
            {
                GoalTracker goalTracker = new GoalTracker();
                goalTracker.RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine();


        }
        while (choice != "6");
    }
}