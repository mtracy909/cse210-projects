using System.Runtime.CompilerServices;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<string> questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
    public ReflectionActivity(string _activityName, string _description) : base(_activityName, _description)
    {
        DoReflectionActivity();
    }
    public void DoReflectionActivity()
    {
        GetStartingMessage();
        double duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        ShowPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.Clear();
        while (startTime < endTime)
        {
            ShowQuestion();
            Countdown(10);
            Console.WriteLine();
            startTime = DateTime.Now;
        }
        Console.WriteLine();
        DoEndingMessage();
    }
    public void ShowPrompt()
    {
        Random random = new Random();
        int num = random.Next(0, prompts.Count);
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {prompts[num]} ---\n");
    }
    public void ShowQuestion()
    {
        Random random = new Random();
        int num = random.Next(0, questions.Count);
        Console.Write($"> {questions[num]} ");
    }
}