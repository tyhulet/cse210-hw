using System.Diagnostics.Contracts;

public abstract class Goals
{
    protected string _goalName;

    protected string _goalDescription;

    protected int _points;

    public Goals(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool CompletedGoal();

    public virtual string GetStringRepresentation()
    {
        return $"{_goalName} | {_goalDescription} | {_points}";
    }
}