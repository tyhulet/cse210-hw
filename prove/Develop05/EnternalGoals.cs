public class EnternalGoals : Goals
{
    public EnternalGoals(string goalName, string goalDescription, int points) : base(goalName, goalDescription, points)
    {

    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool CompletedGoal()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return ($"EternalGoals: {_goalName}, {_goalDescription}, {_points}");
    }
}