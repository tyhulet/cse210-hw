public class PromptGererator
{
    public List<string> Randomprompt = new List<string>(){
        "What was the strongest emotion I felt today?",
        "What was the best part of my day?",
        "Did anything interesting happen at work to day",
        "Did I meet anyone interesting today?",
        "Did anyting happen today that I need to refelect on?",
        "What did i learn about in my scriptures studys today?"

    };

    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(Randomprompt.Count);
        return Randomprompt[index];
    }
}