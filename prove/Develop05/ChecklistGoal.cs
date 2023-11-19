public class ChecklistGoal : Goal
{
    private string _goal;
    private int _bonus;
    private int _needed;
    private int _done;

    public ChecklistGoal() : base()
    {
        if (_done == _needed)
        {
            SetCompletion(true);
        }
    }
    public ChecklistGoal(string type, string name, string description, int points, int bonus, int needed, int done) : base(type, name, description, points)
    {
        _bonus = bonus;
        _needed = needed;
        _done = done;
        if (_done == _needed)
        {
            SetCompletion(true);
        }
        GetGoal();
    }
    public override void SetAttributes()
    {
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of it? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        string response = Console.ReadLine();
        int responseNum = 0;
        while (!int.TryParse(response, out responseNum))
        {
            Console.WriteLine("Please enter a valid number.");
            response = Console.ReadLine();
        }
        SetPoints(responseNum);
        SetCompletion(false);
        SetType("ChecklistGoal");
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string neededResponse = Console.ReadLine();
        _needed = Int32.Parse(neededResponse);
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonusResponse = Console.ReadLine();
        _bonus = Int32.Parse(bonusResponse);

    }
    public int GetBonus()
    {
        return _bonus;
    }
    public int GetNeeded()
    {
        return _needed;
    }
    public int GetDone()
    {
        return _done;
    }
    public override string GetString()
    {
        return $"{GetType()}|{GetName()}|{GetDescription()}|{GetPoints()}|{GetBonus()}|{GetNeeded()}|{GetDone()}";
    }
    public override string GetGoal()
    {
        if (GetCompletion())
        {
            return $"[X] {GetName()} ({GetDescription()}) -- Currently completed: {_done}/{_needed}";
        }
        else
        {
            return $"[ ] {GetName()} ({GetDescription()}) -- Currently completed: {_done}/{_needed}";
        }
    }
    public override void Log()
    {
        _done += 1;
        if (_done == _needed)
        {
            EarnPoints(GetPoints() + GetBonus());
            SetCompletion(true);
        }
        else
        {
            EarnPoints(GetPoints());

        }
        Console.WriteLine($"Congratulations! You have earned {GetEarnedPoints()} points!");

    }
}