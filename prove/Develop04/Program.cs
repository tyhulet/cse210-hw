using System;

class Program
{
    static void Main(string[] args)
    {
        var choice = "";
        do
        {
            Console.WriteLine("Actvity Options: ");
            Console.WriteLine(" 1. Begin Breathing Actvity");
            Console.WriteLine(" 2. Begin Reflecting Activity");
            Console.WriteLine(" 3. Begin Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Please Select an actvity you would like to start.");
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
        while (choice != "4");
    }
}