public class BreathingActivity : Activity
{
    public BreathingActivity(string _activityName, string _description) : base(_activityName, _description)
    {
        DoBreathingActivity();
    }
    public void DoBreathingActivity()
    {
        GetStartingMessage();
        double duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (startTime < endTime)
        {
            BreatheIn();
            BreatheOut();
            Console.WriteLine("");
            startTime = DateTime.Now;
        }
        DoEndingMessage();
    }
    public void BreatheIn()
    {
        Console.Write("Breathe in...");
        Countdown(4);
        Console.WriteLine("");
    }
    public void BreatheOut()
    {
        Console.Write("Now breathe out...");
        Countdown(6);
        Console.WriteLine("");
    }
}