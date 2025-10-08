using System;

class Entry
{
    public string _prompt;
    public string _text;
    public string _date;

    public Entry(string prompt, string text)
    {
        _prompt = prompt;
        _text = text;
        _date = DateTime.Now.ToString("M/d/y");
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_prompt}");
        Console.WriteLine(_text);
    }
}