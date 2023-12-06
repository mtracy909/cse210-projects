public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, double length, string activity, int laps) : base(date, length, activity)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / (GetLength() / 60);
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}