public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date,
    string time, Address address, string weather) :
    base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public string GetFullDetails()
    {
        return $"{GetTitle()} - {GetDescription()}"
        + $"\nOutdoor Gathering - Weather: {_weather}"
        + $"\n{GetDate()} at {GetTime()}"
        + $"\n{GetAddress().GetFullAddress()}";
    }
    public string GetShortDescription()
    {
        return $"Outdoor Gathering - {GetTitle()} - {GetDate()}";
    }
}