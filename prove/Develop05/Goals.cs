public class Goals
{
    private string _goalName;

    private string _goalDescription;

    private int _points;

    public Goals(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = 0;
    }

    public virtual void RecordEvent()
    {

    }

    public bool CompletedGoal()
    {
        return true;
    }


}