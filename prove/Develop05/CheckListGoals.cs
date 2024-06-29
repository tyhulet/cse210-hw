public class CheckListGoals : Goals
{

    protected int _totalCompleted;

    protected int _targetAmount;

    protected int _bounusPoints;


    public CheckListGoals(string goalName, string goalDescription, int points, int targetAmount, int bounusPoints) : base(goalName, goalDescription, points)
    {
        _totalCompleted = 0;
        _targetAmount = targetAmount;
        _bounusPoints = bounusPoints;
    }

    public override int RecordEvent()
    {
        if (_totalCompleted < _targetAmount)
        {
            _totalCompleted++;
            if (_totalCompleted == _targetAmount)
            {
                return _bounusPoints + _points;
            }
            return _points;
        }
        return 0;

    }

    public override bool CompletedGoal()
    {
        return _totalCompleted >= _targetAmount;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoals: Completed: {_totalCompleted} / {_targetAmount} | Bounus: {_bounusPoints} | {_goalName} | {_goalDescription} | {_points}";
    }
}