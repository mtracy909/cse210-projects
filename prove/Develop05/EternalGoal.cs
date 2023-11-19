public class EternalGoal : Goal
{
    private string goal;
    public EternalGoal() : base()
    {
        goal = GetGoal();
    }
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        goal = GetGoal();
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
        SetType("EternalGoal");
        Console.WriteLine();
    }
    public override string GetString()
    {
        return $"{GetType()}|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
    public override string GetGoal()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }
    public override void Log()
    {
        EarnPoints(GetPoints());
        Console.WriteLine($"Congratulations! You have earned {GetEarnedPoints()} points!");
    }
}