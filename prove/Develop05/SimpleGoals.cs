public class SimpleGoals : Goals
{
    private bool _goalCompleted;
    public SimpleGoals(string goalName, string goalDescription, int points) : base(goalName, goalDescription, points)
    {

    }

    public override int RecordEvent()
    {
        if (!_goalCompleted)
        {
            _goalCompleted = true;
            return _points;
        }
        return 0;
    }

    public override bool CompletedGoal()
    {
        return _goalCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoals: Completed: {_goalCompleted} | {_goalName} | {_goalDescription} | {_points}";
    }
}