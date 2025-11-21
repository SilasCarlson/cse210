class ChecklistGoal : Goal
{
    private int _bonusRequirement;
    private int _bonusReward;
    private int _timesCompleted = 0;

    public ChecklistGoal(string[] loadStringProperties): base(loadStringProperties)
    {
    }

    public ChecklistGoal(string name, string description, int reward, int bonusRequirement, int bonusReward) 
        : base(name, description, reward)
    {
        _bonusRequirement = bonusRequirement;
        _bonusReward = bonusReward;
    }

    public override void Display(int index)
    {
        Console.WriteLine($"{index}. [{(IsCompleted() ? "X" : " ")}] {GetName()} ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_bonusRequirement}");
    }

    public override void Complete()
    {
        _timesCompleted++;
    }

    public override bool IsCompleted()
    {
        return _timesCompleted >= _bonusRequirement;
    }

    public int GetBonusRequirement()
    {
        return _bonusRequirement;
    }

    public override int GetReward()
    {
        int reward = base.GetReward();

        if (IsCompleted())
        {
            reward += _bonusReward;
        }

        return reward;
    }

    public override string GetSaveString()
    {
        return $"{GetType().Name}:{GetName()},{GetDescription()},{GetReward()},{_bonusReward},{_bonusRequirement},{_timesCompleted}";
    }

    public override void LoadFromString(string[] loadStringProperties)
    {
        SetName(loadStringProperties[0]);
        SetDescription(loadStringProperties[1]);
        SetReward(int.Parse(loadStringProperties[2]));
        _bonusReward = int.Parse(loadStringProperties[3]);
        _bonusRequirement = int.Parse(loadStringProperties[4]);
        _timesCompleted = int.Parse(loadStringProperties[5]);
    }
}