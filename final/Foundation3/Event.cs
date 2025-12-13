class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetShortDescription()
    {
        return $"{this.GetType().Name}, {_title} on {_date}";
    }

    public string GetStandardDetails()
    {
        return $"{_title} - {_description} on {_date} at {_address.GetAddressString()}";
    }
}