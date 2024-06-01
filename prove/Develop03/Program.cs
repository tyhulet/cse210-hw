using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        //string reference = "John 3:16";
        //string text = "For God so loved the world, that He gave His only begotten Son, that whosever believeth in Him should not perish, but have everlasting life.";
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that He gave His only begotten Son, that whosever believeth in Him should not perish, but have everlasting life.");
        bool quit = false;
        while (!scripture.IsCompletelyHidden() && !quit)
        {
            Console.Clear();
            Console.WriteLine("Scripture Memorizer");
            scripture.Displaytext();

            Console.Write("Press Enter to hide a word of type 'quit to exit: ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "quit")
            {
                quit = true;
            }
            else
            {
                scripture.HideRandomWords();
            }
        }
        if (quit)
        {
            Console.WriteLine("Leaving so soon!");
        }
        else
        {
            Console.Clear();
            scripture.Displaytext();
            Console.WriteLine("Great job, you memorized the scripture!");
        }

    }
}