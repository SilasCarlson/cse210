class SimpleGoal : Goal
{
    public SimpleGoal(string[] loadStringProperties): base(loadStringProperties)
    {
    }

    public SimpleGoal(string name, string description, int reward) : base(name, description, reward)
    {
    }
}