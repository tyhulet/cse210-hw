using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcom to the Journal Program!");
        Journal journal = new Journal();
        string choice;
        do
        {
            Console.WriteLine("Please Select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = PromptGererator.RandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                string entries = Console.ReadLine();

                Entry entry = new Entry(prompt, entries, DateTime.Now.ToString());
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Journal Entries:");
                journal.DisplayAll();


            }
            else if (choice == "3")
            {
                Console.WriteLine("What file are you looking for: ");
                string LoadFile = Console.ReadLine();
                journal.LoadFromFile(LoadFile);
            }
            else if (choice == "4")
            {
                Console.Write("Enter file name to save: ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);

            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye");
            }

            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine();
        }
        while (choice != "5");
    }
}