using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int gradePercentage = int.Parse(userInput);

        // Get the letter grade of the user
        string gradeLetter = "F";
        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }

        // Stretch Challenge
        string gradeLetterSign = "";
        if (gradePercentage % 10 >= 7)
        {
            gradeLetterSign = "+";
        }
        else if (gradePercentage % 10 < 3)
        {
            gradeLetterSign = "-";
        }

        if (gradeLetter == "F") gradeLetterSign = "";
        if (gradeLetter == "A" && gradeLetterSign == "+") gradeLetterSign = "";

        Console.WriteLine($"Your letter grade is: {gradeLetter}{gradeLetterSign}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed the class, congragulations!");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not pass the class, better luck next time!");
        }
    }
}