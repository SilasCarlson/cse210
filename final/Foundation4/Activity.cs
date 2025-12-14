class Activity
{
    private string _date;
    private int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_length} min.) - Distance: {GetDistance().ToString("F2")} miles, Speed: {GetSpeed().ToString("F2")} mph, Pace: {GetPace().ToString("F2")} min. per mile";
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public int GetLength()
    {
        return _length;
    }
}