class Menu
{
    private List<Goal> _goals = [];
    private int _points = 0;

    public void Create()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int userInput = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int reward = int.Parse(Console.ReadLine());

        switch (userInput)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, reward));
                break;

            case 2:
                _goals.Add(new EternalGoal(name, description, reward));
                break;

            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int bonusRequirement = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusReward = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, reward, bonusRequirement, bonusReward));
                break;
        }
    }

    public void List()
    {
        Console.WriteLine("The goals are:");
        
        for (int i = 0; i < _goals.Count; i++) 
        {
            _goals[i].Display(i + 1);
        }
    }

    public void Save()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_points);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
    }

    public void Load()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        for (int i = 0; i < lines.Length; i++)
        {
            if (i == 0)
            {
                _points = int.Parse(lines[i]);
            }
            else
            {
                string[] properties = lines[i].Split(":");
                string className = properties[0];
                string[] goalProperties = properties[1].Split(",");

                if (className == "SimpleGoal")
                {
                    _goals.Add(new SimpleGoal(goalProperties));
                }
                else if (className == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(goalProperties));
                }
                else if (className == "ChecklistGoal")
                {
                    _goals.Add(new ChecklistGoal(goalProperties));
                }
                else
                {
                    _goals.Add(new Goal(goalProperties));
                }
            }
        }
    }

    public void Record()
    {
        Console.WriteLine("The goals are:");
        
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetDescription()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int userInput = int.Parse(Console.ReadLine());

        if (!_goals[userInput - 1].IsCompleted())
        {
            _goals[userInput - 1].Complete();
            _points += _goals[userInput - 1].GetReward();
            Console.WriteLine($"Congragulations! You have earned {_goals[userInput - 1].GetReward()} points!");
            Console.WriteLine($"You now have {_points} points.");
        }
        else
        {
            Console.WriteLine("This goal is already completed!");
        }
    }

    public void Remove()
    {
        Console.WriteLine("The goals are:");
        
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetDescription()}");
        }

        Console.Write("Which goal do you want to delete? ");
        int userInput = int.Parse(Console.ReadLine());

        _goals.RemoveAt(userInput - 1);
    }

    public void Run()
    {
        int userInput = 0;

        while (userInput != 7)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");   
            Console.WriteLine("  2. List Goals");   
            Console.WriteLine("  3. Save Goals");   
            Console.WriteLine("  4. Load Goals");   
            Console.WriteLine("  5. Record Event");   
            Console.WriteLine("  6. Remove Goal");   
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Create();
                    break;

                case 2:
                    List();
                    break;

                case 3:
                    Save();
                    break;

                case 4:
                    Load();
                    break;

                case 5:
                    Record();
                    break;

                case 6:
                    Remove();
                    break;
            }
        }
    }
}