using System;
using System.Reflection;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1380 W 1700th N, Lecture Hall F", "Provo", "Utah", "USA");
        string lectureaddress = address1.DisplayAddress();
        Lectures lecture = new Lectures("Programing Lecture", "The concepts of inhertince in C#", "Feb 13,2024", "2:00 PM", $"{lectureaddress}", "Professer Bryce Atcher", 200);
        lecture.DisplayShortDetails();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectures();
        lecture.DisplayFullDetails("Lecture");

        Console.WriteLine("==============================================");

        Address address2 = new Address("5086 N Canyon Rd", "Provo", "Utah", "USA");
        string outdooraddress = address2.DisplayAddress();
        OutdoorGatherings outdoor = new OutdoorGatherings("Farmers Marketet", "Weekley Farmers Market in the moutains", "Aug 2,2024", "9:00 AM - 2:00Pm", $"{outdooraddress}", "Sunny/Cloudy");
        outdoor.DisplayShortDetails();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayWeather();
        outdoor.DisplayFullDetails("Outdoor Gathering");

        Console.WriteLine("==============================================");
        Address address3 = new Address("1695 S 100 E", "Orem", "Utah", "USA");
        string ReceptionAddress = address3.DisplayAddress();
        Receptions reception = new Receptions("Blood Drive", "A blodd drive for the local blood bank", "Sep 13,2024", "9:00 AM - 3:00 PM", $"{ReceptionAddress}", "blooddriveRSVP@gmail.com");
        reception.DisplayShortDetails();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayRSVP();
        reception.DisplayFullDetails("Reception");

    }
}