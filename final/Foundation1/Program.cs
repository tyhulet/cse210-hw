using System;

class Program
{
    static void Main(string[] args)
    {
        List<Videos> videos = new List<Videos>();

        Videos video1 = new Videos("NFL's Greates Hits of the year 2024", "NFLCentral", 480);
        Comments comment1 = new Comments("Nflfan09", "That hit by Demarcus Lawarnce was huge.");
        Comments comment2 = new Comments("49'sFan", "Some great plays by my San Fran");
        Comments comment3 = new Comments("SportsFan27", "Another greart year of nfl football");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        videos.Add(video1);

        foreach (Videos video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}