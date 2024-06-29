using System.Configuration.Assemblies;

public class GoalTracker
{
    protected List<Goals> _goals = new List<Goals>();

    protected int _playerScore;


    public void Goalstracker()
    {
        _playerScore = 0;
    }

    public void Start()
    {

    }

    public void ShowUserInfo()
    {
        Console.WriteLine($"Your current score is {_playerScore}");
    }

    public void AddGoals()
    {
        var choice = "";
        Console.WriteLine("What type of goal would you like to make?");
        Console.WriteLine("1. Simple Goals");
        Console.WriteLine("2. Eternal Goals");
        Console.WriteLine("3. CheckList Goals");
        choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Enter you simple goal name: ");
            string goalName = Console.ReadLine();
            Console.Write("Enter the details of you goal: ");
            string goalDescription = Console.ReadLine();
            Console.Write("Enter the amount of points the goal is worth: ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new SimpleGoals(goalName, goalDescription, points));
        }
        else if (choice == "2")
        {
            Console.Write("Enter your Enternal Goal: ");
            string goalName = Console.ReadLine();
            Console.Write("Enter the details of your Enternal Goal: ");
            string goalDescription = Console.ReadLine();
            Console.Write("Enter the amount of points this goal is worth: ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new EnternalGoals(goalName, goalDescription, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter your CheckList Goal name: ");
            string goalName = Console.ReadLine();
            Console.Write("Enter the details of your Goal: ");
            string goalDescription = Console.ReadLine();
            Console.Write("Enter the amount of points this goal is worth: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("Enter the amount of time you would like to complete this goal: ");
            int targetAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of bounus points you recevive after meeting your target: ");
            int bounusPoints = int.Parse(Console.ReadLine());
            _goals.Add(new CheckListGoals(goalName, goalDescription, points, targetAmount, bounusPoints));
        }

        else
        {
            Console.WriteLine("Enter a valid choice");
        }
        Console.WriteLine();
    }

    public void ShowGoals()
    {

    }

    public void ShowGoalsDetails()
    {

    }

    public void LoadFile()
    {


    }

    public void SaveFile()
    {

    }

    public void RecordEvent()
    {

    }
}