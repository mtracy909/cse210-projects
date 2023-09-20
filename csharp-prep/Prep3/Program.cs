using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        string response;
        int answer = 0;
        do
        {
            Console.Write("What is the magic number? ");
            response = Console.ReadLine();
            answer = int.Parse(response);
            if (answer > number)
            {
                Console.WriteLine("Lower");
            }
            else if (answer < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.Write("You got it!");
            }
        } while (answer != number);
    }
}