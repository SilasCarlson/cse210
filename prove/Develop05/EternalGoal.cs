class EternalGoal : Goal
{

    public EternalGoal(string[] loadStringProperties): base(loadStringProperties)
    {
    }

    public EternalGoal(string name, string description, int reward) : base(name, description, reward)
    {
    }

    public override string GetSaveString()
    {
        return $"{GetType().Name}:{GetName()},{GetDescription()},{GetReward()}";
    }

    public override void Complete()
    {
        // this can never be completed
        // so do nothing :)  
    }

    public override void LoadFromString(string[] loadStringProperties)
    {
        SetName(loadStringProperties[0]);
        SetDescription(loadStringProperties[1]);
        SetReward(int.Parse(loadStringProperties[2]));
    }
}