using System;

class Program
{
    static void Main(string[] args)
    {
        string _breathingActivityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string _reflectionActivityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string _listingActivityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        int responseNum = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();
            if (int.TryParse(response, out responseNum))
            {
                if (responseNum == 1)
                {
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", _breathingActivityDescription);
                }
                else if (responseNum == 2)
                {
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", _reflectionActivityDescription);
                }
                else if (responseNum == 3)
                {
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", _listingActivityDescription);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
                response = Console.ReadLine();
            }
        }
        while (responseNum != 4);
    }
}