public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date,
    string time, Address address, string email) :
    base(title, description, date, time, address)
    {
        _email = email;
    }
    public string GetFullDetails()
    {
        return $"{GetTitle()} - {GetDescription()}"
        + $"\nReception - RSVP at: {_email}"
        + $"\n{GetDate()} at {GetTime()}"
        + $"\n{GetAddress().GetFullAddress()}";
    }
    public string GetShortDescription()
    {
        return $"Reception - {GetTitle()} - {GetDate()}";
    }
}