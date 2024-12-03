using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("Understanding C# Classes", "CodeAcademy", 300);
        var video2 = new Video("Introduction to Object-Oriented Programming", "TechWithTim", 450);
        var video3 = new Video("Advanced C# Techniques", "ProgrammingGuru", 600);

        video1.AddComment(new Comment("Sam", "This video was so helpful!"));
        video1.AddComment(new Comment("Victoria", "Excellent breakdown of the topic."));
        video1.AddComment(new Comment("Daniel", "I finally understand the concept of classes."));

        video2.AddComment(new Comment("Ted", "Dude, what a great video."));
        video2.AddComment(new Comment("Michaela", "The explanations are so clear."));
        video2.AddComment(new Comment("Jason", "I appreciate the detailed examples."));

        video3.AddComment(new Comment("Mia", "A bit challenging but very educational."));
        video3.AddComment(new Comment("Julian", "excellent tutorial, learned a lot."));
        video3.AddComment(new Comment("Ezra", "Can't wait for more advanced tutorials from you."));

        var videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
