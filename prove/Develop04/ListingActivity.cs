using System.Net;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    private List<string> responses = new List<string>();
    public ListingActivity(string _activityName, string _description) : base(_activityName, _description)
    {
        DoListingActivity();
    }
    public void DoListingActivity()
    {
        GetStartingMessage();
        double duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        ShowPrompt();
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine();
        while (startTime < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            startTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {responses.Count} items!");
        Console.Write($"Your responses are: ");
        foreach (string word in responses)
        {
            Console.Write($"|{word}|");
        }
        Console.WriteLine("\n");
        DoEndingMessage();
    }
    public void ShowPrompt()
    {
        Random random = new Random();
        int num = random.Next(0, prompts.Count);
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Console.WriteLine($" --- {prompts[num]} ---\n");
    }
}