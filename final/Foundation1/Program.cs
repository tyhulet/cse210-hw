using System;

class Program
{
    static void Main(string[] args)
    {
        List<Videos> videos = new List<Videos>();

        Videos video1 = new Videos("NFL's Greates Hits of the year 2024", "NFLCentral", 480);
        Comments commentvid1_1 = new Comments("Nflfan09", "That hit by Demarcus Lawarnce was huge.");
        Comments commentvid1_2 = new Comments("49'sFan", "Some great plays by San Fran.");
        Comments commentvid1_3 = new Comments("SportsFan27", "Another greart year of NFL football.");

        video1.AddComment(commentvid1_1);
        video1.AddComment(commentvid1_2);
        video1.AddComment(commentvid1_3);
        videos.Add(video1);

        Videos video2 = new Videos("Finding Strength in Jesus Christ", "The Church of Jesus Chirst of Latter Day Saints", 115);
        Comments commentvid2_1 = new Comments("User24601", "With Christ by our side we can do anyting.");
        Comments commentvid2_2 = new Comments("AmonWasHere", "The world needs more of this.");
        Comments commentvid2_3 = new Comments("MamaBear95", "#HearHim");

        video2.AddComment(commentvid2_1);
        video2.AddComment(commentvid2_2);
        video2.AddComment(commentvid2_3);
        videos.Add(video2);

        Videos video3 = new Videos("Harry Potter | Experince [1st September]", "rising okami", 305);
        Comments commentvid3_1 = new Comments("harrypotterFan", "I woudld not have my love of reading if not for Harry Potter.");
        Comments commentvid3_2 = new Comments("HufflePuffHouse", "It truly was an experince with this world.");
        Comments commentvid3_3 = new Comments("trooper66", "The perfect song to pair with a perfect series.");

        video3.AddComment(commentvid3_1);
        video3.AddComment(commentvid3_2);
        video3.AddComment(commentvid3_3);
        videos.Add(video3);


        Videos video4 = new Videos("Marvel Studios' Avengers: Endgame - Official Trailer", "Marvel Entertainment", 146);
        Comments commentvid4_1 = new Comments("MarvelFan875", "This trailer hits differently after all these years.");
        Comments commentvid4_2 = new Comments("Ironmanforever", "Its going to be weired not seeing Iron Man in these movies.");
        Comments commentvid4_3 = new Comments("Spoiler28951", "Everyone lives and has a happy ending.");

        video4.AddComment(commentvid4_1);
        video4.AddComment(commentvid4_2);
        video4.AddComment(commentvid4_3);
        videos.Add(video4);

        foreach (Videos video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}