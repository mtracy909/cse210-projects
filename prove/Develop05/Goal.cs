public abstract class Goal
{
    private string _type;
    private string _name;
    private string _description;
    private int _points;
    private int _earnedPoints;
    private bool _completion;
    public Goal()
    {
        SetAttributes();
    }
    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _completion = false;
    }
    public new string GetType()
    {
        return _type;
    }
    public void SetType(string type)
    {
        _type = type;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public int GetEarnedPoints()
    {
        return _earnedPoints;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public bool GetCompletion()
    {
        return _completion;
    }
    public void SetCompletion(bool completion)
    {
        _completion = completion;
    }
    public void EarnPoints(int earned)
    {
        _earnedPoints = earned;
    }
    public abstract void SetAttributes();
    public abstract string GetString();
    public abstract string GetGoal();
    public abstract void Log();
}