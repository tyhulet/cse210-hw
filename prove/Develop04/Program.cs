using System;

class Program
{
    static void Main(string[] args)
    {
        var choice = "";
        do
        {
            Console.WriteLine("Activity Options: ");
            Console.WriteLine(" 1. Begin Breathing Activity");
            Console.WriteLine(" 2. Begin Reflecting Actiivity");
            Console.WriteLine(" 3. Begin Listing Actiivity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Please Select an activity you would like to start.");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunBreathing();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.RunReflectingActvity();
            }
            else if (choice == "3")
            {
                ListingActvity listingActvity = new ListingActvity();
                listingActvity.RunListingActvity();

            }
            else if (choice == "4")
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