using System.ComponentModel;

class Activity
{
    private string _name;
    private string _description;
    private int _duration = 0;
    private List<string> _loadingAnimation = ["|", "/", "-", "\\", "|", "/", "-", "\\"];
    private int _timesCompleted = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Initialize()
    {
        DisplayIntroduction();
        DisplayGetReady();
    }

    public void DisplayIntroduction()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        // Get the amount of seconds
        Console.Write("How long, in seconds, would you like for your session? ");
        int userInput = int.Parse(Console.ReadLine());
        _duration = userInput;
    }

    public void DisplayConclusion()
    {
        // First part
        Console.WriteLine("\n");
        Console.WriteLine("Well Done!!");
        DisplayAnimation(3000);

        // Second part
        Console.WriteLine("\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        DisplayAnimation(3000);

        // increment times completed
        _timesCompleted++;
    }

    public void DisplayGetReady()
    {
        // clear the screen
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayAnimation(3000);
    }

    public void DisplayAnimation(int duration, int animationSpeed = 300)
    {
        int index = 0;
        DateTime endTime = DateTime.Now.AddMilliseconds(duration);

        Console.Write(_loadingAnimation[index]);
        Thread.Sleep(animationSpeed);

        while (DateTime.Now < endTime)
        {
            index++;

            if (index >= _loadingAnimation.Count())
            {
                index = 0;
            }

            Console.Write("\b \b");
            Console.Write(_loadingAnimation[index]);
            Thread.Sleep(animationSpeed);
        }

        // remove
        Console.Write("\b \b");
    }

    public void DisplayCountdown(int duration)
    {
        DateTime endTime = DateTime.Now.AddMilliseconds(duration);

        Console.Write(duration / 1000);
        Thread.Sleep(1000);

        while (DateTime.Now < endTime)
        {
            duration -= 1000;

            if (duration < 0)
            {
                duration = 0;
            }

            Console.Write("\b \b");
            Console.Write(duration / 1000);
            Thread.Sleep(1000);
        }

        // remove
        Console.Write("\b \b");
    }

    public int GetDuration()
    {
        return _duration;
    }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
}