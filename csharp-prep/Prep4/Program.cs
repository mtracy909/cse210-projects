using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int answer;
        int sum = 0;
        int total = 0;
        int largest = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            string response = Console.ReadLine();
            answer = int.Parse(response);
            numbers.Add(answer);
        }
        while (answer != 0);
        foreach (int number in numbers)
        {
            total++;
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / total}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}