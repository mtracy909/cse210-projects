public abstract class Activity
{
    private string _date;
    private double _length;
    private string _activity;
    public Activity(string date, double length, string activity)
    {
        _date = date;
        _length = length;
        _activity = activity;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date} {_activity} ({_length} min) "
        + $"- Distance: {Math.Round(GetDistance(), 2)} miles, Speed: {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile";
    }
    public double GetLength()
    {
        return _length;
    }
}