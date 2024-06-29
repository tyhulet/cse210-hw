using System.Configuration.Assemblies;

public class GoalTracker
{
    private List<Goals> _goals = new List<Goals>();

    private int _playerScore;


    public void Goalstracker()
    {
        _playerScore = 0;
    }

    public void ShowUserInfo()
    {
        Console.WriteLine($"Your current score is {_playerScore}");
    }

    public void AddGoals()
    {
        Console.WriteLine("What type of goal would you like to make?");
        Console.WriteLine("1. Simple Goals");
        Console.WriteLine("2. Eternal Goals");
        Console.WriteLine("3. CheckList Goals");
        string choice = Console.ReadLine();

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

    public void ShowGoalsDetails()
    {

    }

    public void LoadGoalFile()
    {
        Console.WriteLine("Enter the filename you need: ");
        string LoadFile = Console.ReadLine();
        using (StreamReader outputfile = new StreamReader(LoadFile))
        {
            string[] lines = File.ReadAllLines(LoadFile);
            _playerScore = int.Parse(lines[0]);

            foreach (string line in lines)
            {
                string[] parts = line.Split(", ");
                string goalType = parts[0].Split(":")[0];
                string _goalName = parts[1];
                string _goalDescription = parts[2];
                int _playerScore = int.Parse(parts[3]);
            }
        }

    }

    public void SaveGoalFile()
    {
        Console.WriteLine("Enter the name of the file you would like to save: ");
        string GoalFile = Console.ReadLine();
        using (StreamWriter outputfile = new StreamWriter(GoalFile))
        {
            outputfile.WriteLine(_playerScore);
            foreach (Goals _goals in _goals)
            {
                outputfile.WriteLine(_goals.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goal File Saved");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which Goal did you accomplish?");
        int index = int.Parse(Console.ReadLine());
        if (index >= 0 && index < _goals.Count)
        {
            _playerScore += _goals[index].RecordEvent();
        }
        Console.WriteLine($"Your current Score is: {_playerScore}");
    }
}