using System;

class Menu
{
    private BreathingActivity _breathingActivity = new BreathingActivity();
    private ReflectingActivity _reflectingActivity = new ReflectingActivity();
    private ListingActivity _listingActivity = new ListingActivity();

    public void Run()
    {
        int userInput = 0;

        while (userInput != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine($"1. Start breathing activity ({_breathingActivity.GetTimesCompleted()} times completed)");
            Console.WriteLine($"2. Start reflecting activity ({_reflectingActivity.GetTimesCompleted()} times completed)");
            Console.WriteLine($"3. Start listing activity ({_listingActivity.GetTimesCompleted()} times completed)");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    _breathingActivity.Initialize();
                    _breathingActivity.Run();
                    break;

                case 2:
                    _reflectingActivity.Initialize();
                    _reflectingActivity.Run();
                    break;

                case 3:
                    _listingActivity.Initialize();
                    _listingActivity.Run();
                    break;
            }

        }
    }
}