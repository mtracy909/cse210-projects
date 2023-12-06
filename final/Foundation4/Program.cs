using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();
        Running running = new Running("03 Nov 2022", 30, "Running", 3.0);
        activities.Add(running);
        Cycling cycling = new Cycling("05 Nov 2022", 45, "Cycling", 9.0);
        activities.Add(cycling);
        Swimming swimming = new Swimming("07 Nov 2022", 25, "Swimming", 50);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

    }
}