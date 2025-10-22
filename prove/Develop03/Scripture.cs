class Scripture
{
    private List<Word> _words = [];
    private Reference _reference;
    private int _hiddenWordCount = 0;

    public Scripture(Reference reference, string content)
    {
        _reference = reference;

        // Populate the words list using the provided content
        string[] words = content.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Write(_reference.GetContent());
        foreach (Word word in _words)
        {
            Console.Write($" {word.GetContent()}");
        }
        Console.WriteLine();
    }

    public bool HideRandomWord()
    {
        // If there are no more availabe words then exit this function
        if (_hiddenWordCount == _words.Count) return false;

        // Get a random word
        Random random = new Random();
        Word randomWord = _words[random.Next(_words.Count)];

        // Make sure the word is not already hidden
        // if it is then get another random word until it's not hidden
        while (randomWord.GetIsHidden())
        {
            randomWord = _words[random.Next(_words.Count)];
        }

        // Hide the word
        _hiddenWordCount++;
        randomWord.SetIsHidden(true);

        return true;
    }
}