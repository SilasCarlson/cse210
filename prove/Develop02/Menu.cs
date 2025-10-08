using System;

class Menu
{
    public Journal _journal = new Journal();
    public PromptGeneartor _promptGeneartor = new PromptGeneartor();
    public List<string> _generatedPrompts = new List<string>();

    public void Write()
    {
        // Make sure that there are still available prompts
        if (_promptGeneartor._prompts.Count <= _generatedPrompts.Count)
        {
            Console.WriteLine("There currently are no more prompts!");
            return;
        }

        // Get the prompt
        string prompt = _promptGeneartor.GetRandomPrompt(_generatedPrompts);
        _generatedPrompts.Add(prompt);

        // Get user input
        Console.WriteLine(prompt);
        Console.Write("> ");
        string userInput = Console.ReadLine();

        // Add the entry to the journal
        _journal._entries.Add(new Entry(prompt, userInput));
    }

    public void Display()
    {
        _journal.Display();
    }

    public void Load()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        _journal.Load(fileName);

        // get prompts for today
        List<string> prompts = _journal.GetPromptsFromToday();
        _generatedPrompts.AddRange(prompts);
    }

    public void Save()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        _journal.Save(fileName);
    }

    public void Run()
    {
        int userInput = 0;
        while (userInput != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Write();
                    break;

                case 2:
                    Display();
                    break;

                case 3:
                    Load();
                    break;

                case 4:
                    Save();
                    break;
            }
        }
    }
}