using System.Reflection;

public class ReflectingActivity : MainActvity
{
    protected List<string> _reflectingprompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    protected List<string> _reflectingQuestions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were no successful?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the furure?"
    };

    public ReflectingActivity()
    {
        _name = "Reflection Activity";
        _actvityDescription = "will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void RunReflectingActvity()
    {
        DisplayStartingMessage();

        RandomReflectionPrompt();

        DisplayEndingMessage();
    }

    public void RandomReflectionPrompt()
    {
        Console.WriteLine();
        Random random = new Random();
        int index = random.Next(_reflectingprompts.Count());
        Console.WriteLine(_reflectingprompts[index]);
        Console.WriteLine();
    }

    public string RandomRefelectionQuestion()
    {
        Random random = new Random();
        int questionIndex = random.Next(_reflectingQuestions.Count());
        return _reflectingQuestions[questionIndex];
    }


}