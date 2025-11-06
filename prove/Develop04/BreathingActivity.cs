class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    
    public void Run()
    {
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int breatheInDuration = 4000;
        int breatheOutDuration = 6000;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n");
            Console.Write("Breathe in...");
            DisplayCountdown(breatheInDuration);

            Console.WriteLine();
            Console.Write("Breathe out...");
            DisplayCountdown(breatheOutDuration);
        }

        DisplayConclusion();
    }
}