public class Activity
{
    private string _activityName;
    private string _description;
    private double _duration;
    private double _seconds;
    private string _startingMessage;
    private string _endingMessage;

    //Each activity should end with a common ending message that tells the user 
    //they have done a good job, and pause and then tell them the activity they 
    //have completed and the length of time and pauses for several seconds before finishing.
    public Activity(string activityName, string description)
    {
        Console.Clear();
        _activityName = activityName;
        _description = description;
        _startingMessage = $"Welcome to the {_activityName}.\n\n{_description}\n\n";
    }
    public void GetStartingMessage()
    {
        Console.Write(_startingMessage);
        Console.Write("How long, in seconds, would you like for your session? ");
        string _response = Console.ReadLine();
        while (!double.TryParse(_response, out _seconds))
        {
            Console.Write("Enter a valid number: ");
            _response = Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine("Get ready...");
        Countdown(5);
        Console.WriteLine("");
        _duration = _seconds;
        _endingMessage = $"You have completed another {_duration} seconds of the {_activityName}.";
    }
    public double GetDuration()
    {
        return _duration;
    }
    public void DoEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Countdown(5);
        Console.WriteLine("");
        Console.WriteLine(_endingMessage);
        Countdown(5);
    }
    public void Countdown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i < 10)
            {
                Console.Write("\b \b");
            }
            else
            {
                Console.Write("\b\b  \b\b");
            }
        }
    }
}