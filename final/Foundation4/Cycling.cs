class Cycling : Activity
{
    private int _speed;

    public Cycling(string date, int length, int speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (double)_speed * GetLength() / 60;
    }

    public override double GetSpeed()
    {
        return (double)_speed;
    }

    public override double GetPace()
    {
        return (double)60 / _speed;
    }
}