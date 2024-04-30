using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int usernumber = -1;
        while (usernumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userresponse = Console.ReadLine();
            usernumber = int.Parse(userresponse);

            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The Sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The Average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The Max is: {max}");
    }
}