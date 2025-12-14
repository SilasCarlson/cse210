class Running : Activity
{
    private int _distance;

    public Running(string date, int length, int distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return (double)_distance;
    }

    public override double GetSpeed()
    {
        return (double)_distance / GetLength() * 60;
    }

    public override double GetPace()
    {
        return (double)GetLength() / _distance;
    }
}