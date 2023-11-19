using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string _response = "";
        Scripture scripture = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        while (_response != "quit")
        {
            while (scripture.GetCounter() < (scripture.GetWordsList().Count))
            {
                if (_response == "")
                {
                    Console.Clear();
                    Console.WriteLine($"{reference.getReference()} {scripture.GetScripture()}");
                    Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
                    scripture.HideWords();
                    List<string> _newStringList = new List<string>();
                    scripture.SetStringList(_newStringList);
                }
                else
                {
                    Console.WriteLine("Please enter a valid response.");
                }
                _response = Console.ReadLine().ToLower();
                if (_response == "quit")
                {
                    break;
                }
            }
            if (_response != "quit")
            {
                Console.Clear();
                Console.WriteLine($"{reference.getReference()} {scripture.GetScripture()}");
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            }
        }
    }
}