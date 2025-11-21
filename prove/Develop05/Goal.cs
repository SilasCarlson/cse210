class Goal
{
    private string _name;
    private string _description;
    private int _reward;
    private bool _isCompleted = false;

    public Goal(string[] loadStringProperties)
    {
        LoadFromString(loadStringProperties);
    }

    public Goal(string name, string description, int reward) 
    {
        _name = name;
        _description = description;
        _reward = reward;
    }

    public virtual void Display(int index)
    {
        Console.WriteLine($"{index}. [{(_isCompleted ? "X" : " ")}] {_name} ({_description})");
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetReward(int reward)
    {
        _reward = reward;
    }

    public virtual int GetReward()
    {
        return _reward;
    }

    public virtual void Complete()
    {
        _isCompleted = true;
    }

    public virtual bool IsCompleted()
    {
        return _isCompleted;
    }

    public virtual string GetSaveString()
    {
        return $"{GetType().Name}:{_name},{_description},{_reward},{_isCompleted}";
    }

    public virtual void LoadFromString(string[] loadStringProperties)
    {
        _name = loadStringProperties[0];
        _description = loadStringProperties[1];
        _reward = int.Parse(loadStringProperties[2]);
        _isCompleted = bool.Parse(loadStringProperties[3]);
    }
}