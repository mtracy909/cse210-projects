public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, double length, string activity, double speed) : base(date, length, activity)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * GetLength() / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}