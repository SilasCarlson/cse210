using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = false;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guesses = 0;
            int userGuess = 0;
            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                guesses++;

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guesses} guesses!");
                    Console.Write("Would you like to play again? (y/n) ");
                    string userInput = Console.ReadLine();

                    playAgain = (userInput == "y" || userInput == "yes");
                }
            }
        }
        while (playAgain);
    }
}