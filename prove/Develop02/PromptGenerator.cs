public class PromptGenerator {
    public List<string> _prompts;

    public string GetRandomPrompt() 
    {
        Random randomNumberGenerator = new Random();
        int number = randomNumberGenerator.Next(1,5);
        string prompt = "";

        if (number == 1)
        {
            prompt = "Who was the most interesting person I interacted with today?";
        }
        else if (number == 2)
        {
            prompt = "What was the best part of my day?";
        }
        else if (number == 3)
        {
            prompt = "How did I see the hand of the Lord in my life today?";
        }
        else if (number == 4)
        {
            prompt = "What was the strongest emotion I felt today?";
        }
        else 
        {
            prompt = "If I had one thing I could do over today, what would it be?";
        }
        // Console.WriteLine(prompt);
        return prompt;
    }
}