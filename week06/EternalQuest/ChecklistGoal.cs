public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonus;
    private int _currentCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }

    public override string GetDetailsString()
    {
        string check = (_currentCount >= _targetCount) ? "X" : " ";
        return $"[{check}] {base.GetDetailsString()} -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonus}|{_targetCount}|{_currentCount}";
    }
}
