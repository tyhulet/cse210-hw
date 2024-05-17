using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcom to the Journal Program!");

        string choice;
        do
        {
            Console.WriteLine("Please Select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice = Console.ReadLine();
            if (choice == "1")
            {

            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {

            }
            else if (choice == "4")
            {

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