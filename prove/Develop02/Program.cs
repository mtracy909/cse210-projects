using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        int responseNum = 0;
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            string response = Console.ReadLine();
            if (int.TryParse(response, out responseNum))
            {
                if (responseNum == 1)
                {
                    Entry entry = new Entry();
                    entry._EntryDate = DateTime.Now.ToShortDateString();
                    Random rnd = new Random();
                    entry._Prompt = entry.prompts[rnd.Next(entry.prompts.Count - 1)];
                    Console.WriteLine(entry._Prompt);
                    entry._Response = Console.ReadLine();
                    journal.entries.Add($"Date: {entry._EntryDate} - Prompt: {entry._Prompt} - Response: {entry._Response}");
                }
                else if (responseNum == 2)
                {
                    foreach (string entry in journal.entries)
                    {
                        Console.WriteLine($"{entry}\n");
                    }
                }
                else if (responseNum == 3)
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                        journal.entries.Add(line);
                    }
                }
                else if (responseNum == 4)
                {
                    Console.Write("What is the filename? ");
                    string file = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(file))
                    {
                        foreach (string entry in journal.entries)
                        {
                            outputFile.WriteLine(entry);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        while (responseNum != 5);
    }
}