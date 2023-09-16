using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percentage: ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("Try again next time");
        }
    }
}