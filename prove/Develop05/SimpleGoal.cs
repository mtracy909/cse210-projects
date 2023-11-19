public class SimpleGoal : Goal
{
    private string goal;
    public SimpleGoal() : base()
    {
        goal = GetGoal();
    }
    public SimpleGoal(string type, string name, string description, int points, bool completion = false) : base(type, name, description, points)
    {
        goal = GetGoal();
        SetCompletion(completion);
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
        SetType("SimpleGoal");
        Console.WriteLine();
    }
    public override string GetString()
    {
        return $"{GetType()}|{GetName()}|{GetDescription()}|{GetPoints()}|{GetCompletion()}";
    }
    public override string GetGoal()
    {
        if (GetCompletion())
        {
            return $"[X] {GetName()} ({GetDescription()})";
        }
        else
        {
            return $"[ ] {GetName()} ({GetDescription()})";
        }
    }
    public override void Log()
    {
        SetCompletion(true);
        EarnPoints(GetPoints());
        Console.WriteLine($"Congratulations! You have earned {GetEarnedPoints()} points!");
    }
}