using System;

class Program
{
    static void Main(string[] args)
    {
        // Scriptures
        List<Scripture> scriptures = [
            new Scripture(new Reference("John", 3, 16, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Psalm", 23, 1, 2), "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters."),
            new Scripture(new Reference("Moses", 1, 1, 1), "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."),
            new Scripture(new Reference("Alma", 37, 6, 7), "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise. And the Lord God doth work by means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls."),
            new Scripture(new Reference("Enos", 1, 8, 8), "And he said unto me: Because of thy faith in Christ, whom thou hast never before heard nor seen. And many years pass away before he shall manifest himself in the flesh; wherefore, go to, thy faith hath made thee whole.")
        ];

        // Get a random scripture
        Random random = new Random();
        Scripture randomScripture = scriptures[random.Next(scriptures.Count)];

        // Main program loop
        string userInput = "";
        while (userInput != "quit")
        {
            // Display
            Console.Clear();
            randomScripture.Display();
            Console.WriteLine();

            // User input
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            // Hide a random scripture
            // If there are no more available scriptures then exit
            if (!randomScripture.HideRandomWord()) return;
        }
    }
}