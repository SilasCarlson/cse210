class Lecture : Event
{
    private string _speaker;
    private int _maximumCapacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int maximumCapacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _maximumCapacity = maximumCapacity;
    }

    public string GetFullDetails()
    {
        return $"{GetShortDescription()}\nSpeaker: {_speaker}, Capacity: {_maximumCapacity}";
    }
}