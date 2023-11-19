using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int responseNum = 0;
        int goalTypeNum;
        int totalPoints = 0;
        string fileName;
        List<Goal> goals = new List<Goal>();
        while (responseNum != 6)
        {
            Console.WriteLine($"You are level {totalPoints / 500}.");
            Console.WriteLine($"You have {totalPoints} points.\n\nMenu Options: ");
            Console.WriteLine("  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();
            while (!int.TryParse(response, out responseNum))
            {
                Console.WriteLine("Please enter a valid number.");
                response = Console.ReadLine();
            }
            if (responseNum == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();
                while (!int.TryParse(goalType, out goalTypeNum))
                {
                    Console.WriteLine("Please enter a valid number.");
                    goalType = Console.ReadLine();
                }
                if (goalTypeNum == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    goals.Add(simpleGoal);
                }
                else if (goalTypeNum == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    goals.Add(eternalGoal);
                }
                else if (goalTypeNum == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    goals.Add(checklistGoal);
                }
            }
            else if (responseNum == 2)
            {
                Console.WriteLine("The goals are:");
                for (int i = 0; i < goals.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetGoal()}");
                }
                Console.WriteLine();
            }
            else if (responseNum == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    for (int i = 0; i <= goals.Count(); i++)
                    {
                        if (i == 0)
                        {
                            outputFile.WriteLine($"{totalPoints}");
                        }
                        else
                        {
                            outputFile.WriteLine($"{goals[i - 1].GetString()}");
                        }
                    }
                }

            }
            else if (responseNum == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                totalPoints = Int32.Parse(lines[0]);
                for (int i = 1; i < lines.Count(); i++)
                {
                    string[] parts = lines[i].Split("|");
                    if (parts[0] == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(parts[0], parts[1], parts[2], Int32.Parse(parts[3]), Convert.ToBoolean(parts[4]));
                        goals.Add(simpleGoal);
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(parts[0], parts[1], parts[2], Int32.Parse(parts[3]));
                        goals.Add(eternalGoal);
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal(parts[0], parts[1], parts[2], Int32.Parse(parts[3]), Int32.Parse(parts[4]), Int32.Parse(parts[5]), Int32.Parse(parts[6]));
                        goals.Add(checklistGoal);
                    }
                }
                Console.WriteLine();
            }
            else if (responseNum == 5)
            {
                Console.WriteLine("The goals are: ");
                for (int i = 0; i < goals.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
                }
                Console.Write("Which goal did you accomplish? ");
                int goal = Int32.Parse(Console.ReadLine()) - 1;
                goals[goal].Log();
                totalPoints += goals[goal].GetEarnedPoints();
                Console.WriteLine($"You now have {totalPoints} points.\n");
            }
        }
    }
}