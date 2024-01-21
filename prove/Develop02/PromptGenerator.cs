using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>{
        "What emotions do you find hardest to accept? How do you handle those emotions?",
        "What do you fear most? Have your fears changed throughout your life?",
        "What values do you consider most important to you? Are your actions aligned with those values?",
        "In what situations do you trust yourself most?",
        "Who was the most interesting person that I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt () 
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
        
    }
}
