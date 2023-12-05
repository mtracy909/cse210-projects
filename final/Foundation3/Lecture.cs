public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, string date,
    string time, Address address, string speaker, int capacity) :
    base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetFullDetails()
    {
        return $"{GetTitle()} - {GetDescription()}"
        + $"\nLecture - Speaker: {_speaker} - Capacity: {_capacity}"
        + $"\n{GetDate()} at {GetTime()}"
        + $"\n{GetAddress().GetFullAddress()}";
    }
    public string GetShortDescription()
    {
        return $"Lecture - {GetTitle()} - {GetDate()}";
    }
}