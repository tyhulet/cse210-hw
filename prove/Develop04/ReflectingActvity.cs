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
        _name = "Reflecting Actvity";
        _actvityDescription = "will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void RunReflectingActvity()
    {
        DisplayStartingMessage();
        SessionLength();
        RandomReflectionPrompt();
        DisplayEndingMessage();
    }

    public string RandomReflectionPrompt()
    {
        Random random = new Random();
        int reflectindex = random.Next(_reflectingprompts.Count());
        return _reflectingprompts[reflectindex];
    }

    public string RandomRefelectionQuestion()
    {
        Random random = new Random();
        int questionIndex = random.Next(_reflectingQuestions.Count());
        return _reflectingQuestions[questionIndex];
    }


    public void ShowReflectionPrompt()
    {
        Console.WriteLine("Anwser as many time as you can to the flowing prompt: ");
        Console.WriteLine();
        Random random = new Random();
        int promptindex = random.Next(_reflectingprompts.Count());
        Console.WriteLine(_reflectingprompts[promptindex]);
        Console.WriteLine();
    }

    public void ShowReflectionQuestions()
    {

    }
}