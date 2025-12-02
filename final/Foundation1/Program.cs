using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create
        Video video1 = new Video("How to cook macaroni and cheese", "HowToVideos", 376);
        video1.AddComment(new Comment("Jimmy", "Wow such a cool video!"));
        video1.AddComment(new Comment("Sally", "That is such a cool video!"));
        video1.AddComment(new Comment("Billy", "I learned so much from this video."));
        video1.AddComment(new Comment("Sarah", "What camera did you use?"));
        videos.Add(video1);

        Video video2 = new Video("Random Song Music Video", "Song Artist", 194);
        video2.AddComment(new Comment("Holly", "What a wonderful song!"));
        video2.AddComment(new Comment("Billy", "This song slaps."));
        video2.AddComment(new Comment("Karen", "Now we are cooking with gas."));
        videos.Add(video2);

        Video video3 = new Video("This is a video title", "Random Person", 764);
        video3.AddComment(new Comment("Joe", "Wow this is so cool!"));
        video3.AddComment(new Comment("Anderson", "Now this is an original idea."));
        video3.AddComment(new Comment("Bob", "I'm not too sure about this video, not your best work."));
        video3.AddComment(new Comment("John", "Yikes, I wouldn't do that."));
        videos.Add(video3);

        Video video4 = new Video("How to make a paper airplane that flies over 1,000 MPH!!", "The Real Deal", 1024);
        video4.AddComment(new Comment("Jacob", "Wow I can't believe that this plan flies so far!"));
        video4.AddComment(new Comment("Meredith", "Just won this year's contest with this."));
        video4.AddComment(new Comment("Jill", "So much paper..."));
        videos.Add(video4);

        // Display
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}