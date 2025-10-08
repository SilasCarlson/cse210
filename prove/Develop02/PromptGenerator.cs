using System;

class PromptGeneartor
{
    public List<string> _prompts = [
        "What is something you did today?",
        "How did you feel today?",
        "What exciting thing happened today?",
        "What did you have to eat today?",
        "What is something that I can improve on?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    ];

    public string GetRandomPrompt(List<string> excludedPrompts)
    {
        string prompt;
        do
        {
            Random random = new Random();
            prompt = _prompts[random.Next(0, _prompts.Count)];
        } while (excludedPrompts.Contains(prompt));

        return prompt;
    }
}