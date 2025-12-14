class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("12/15/2025", 30, 3));
        activities.Add(new Cycling("12/16/2025", 45, 15));
        activities.Add(new Swimming("12/17/2025", 60, 50));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}