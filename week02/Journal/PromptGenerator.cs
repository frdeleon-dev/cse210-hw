using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the happiest moment of my day? ",
        "What challenge did I overcome today? ",
        "What is one thing I learned today? ",
        "Who made a positive impact on my day, and why? ",
        "What is something I am grateful for today? ",
        "If I could improve one thing about today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}