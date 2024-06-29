public class CheckListGoals : Goals
{

    protected int _totalCompleted;

    protected int _targetCompleted;

    protected int _bounusPoints;


    public CheckListGoals(string goalName, string goalDescription, int points, int targetCompleted, int bounusPoints) : base(goalName, goalDescription, points)
    {
        _totalCompleted = 0;
        _targetCompleted = targetCompleted;
        _bounusPoints = bounusPoints;
    }

    public override int RecordEvent()
    {
        if (_totalCompleted < _targetCompleted)
        {
            _totalCompleted++;
            if (_totalCompleted == _targetCompleted)
            {
                return _bounusPoints + _points;
            }
            return _points;
        }
        return 0;

    }

    public override bool CompletedGoal()
    {
        return _totalCompleted >= _targetCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoals: Completed: {_totalCompleted} / {_targetCompleted} | Bounus: {_bounusPoints} | {_goalName} | {_goalDescription} | {_points}";
    }
}