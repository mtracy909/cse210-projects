using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Lecture Event
        Address lectureAddress = new Address("50 W Viking Drive", "Rexburg", "Idaho", "USA");
        Lecture lecture = new Lecture("Ted Talk",
        "A Ted Talk by someone you've never heard of",
        "12/15/23", "2:30 P.M.", lectureAddress, "A Rando", 500);
        Console.WriteLine($"{lecture.GetStandardDetails()}\n");
        Console.WriteLine($"{lecture.GetFullDetails()}\n");
        Console.WriteLine($"{lecture.GetShortDescription()}\n");

        //Reception Event
        Address receptionAddress = new Address("356 Maiden Drive", "Lanchester", "New York", "USA");
        Reception reception = new Reception("Maddie's Wedding Reception",
        "A wedding reception for our beloved Maddie", "12/17/23",
        "1:30 P.M.", receptionAddress, "rsvpformaddiewedding@gmail.com");
        Console.WriteLine($"{reception.GetStandardDetails()}\n");
        Console.WriteLine($"{reception.GetFullDetails()}\n");
        Console.WriteLine($"{reception.GetShortDescription()}\n");

        //Outdoor Gathering Event
        Address outdoorAddress = new Address("4 Canal Street", "South El Monte", "California", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Ward Party",
        "A final party for the ward to celebrate the end of the semester", "12/19/23",
        "5:30 P.M.", outdoorAddress, "Partly Cloudy");
        Console.WriteLine($"{outdoorGathering.GetStandardDetails()}\n");
        Console.WriteLine($"{outdoorGathering.GetFullDetails()}\n");
        Console.WriteLine($"{outdoorGathering.GetShortDescription()}");
    }
}