using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video #1
        Video video1 = new Video("My Baptism", "Ghost Spell Channel", 1600);
        video1.AddComment(new Comment("Carlos", "Congratulations on your baptism!"));
        video1.AddComment(new Comment("Maria", "Your testimony was very inspiring."));
        video1.AddComment(new Comment("John", "May God continue to bless your journey."));
        videos.Add(video1);

        // Video #2
        Video video2 = new Video("How to Pray to God", "Blessing Channel", 1200);
        video2.AddComment(new Comment("Anna", "This helped me improve my prayers."));
        video2.AddComment(new Comment("Peter", "Thank you for explaining it so clearly."));
        video2.AddComment(new Comment("Louis", "I will apply these tips in my daily life."));
        videos.Add(video2);

        // Video #3
        Video video3 = new Video("Book of Mormon", "My Bible Class", 450);
        video3.AddComment(new Comment("Sophia", "I love learning about the Book of Mormon."));
        video3.AddComment(new Comment("Diego", "This was a great introduction to the scriptures."));
        video3.AddComment(new Comment("Elena", "Please make more videos like this!"));
        videos.Add(video3);



        foreach (Video video in videos)
        {
            Console.WriteLine("*************");
            Console.WriteLine($"Title: {video.GetVideoName()}");
            Console.WriteLine($"Author: {video.GetVideoAuthor()}");
            Console.WriteLine($"Length: {video.GetVideoLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.CommentCount()}");
            Console.WriteLine("");
            Console.WriteLine("Comments:");


            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommentAuthor()}: {comment.GetCommentText()}");
            }

            Console.WriteLine(); 
        }

    }
}