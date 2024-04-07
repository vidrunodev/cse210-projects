using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Creating videos
        Video video1 = new Video("Introduction to Machine Learning", "John Doe", 120);
        Video video2 = new Video("Python Programming Basics", "Jane Smith", 180);
        Video video3 = new Video("Introduction to Astrophysics", "Dr. Amanda Johnson", 150);

        //Adding comments to videos
        video1.AddComment("Alice", "Great explanation! Really helped me understand the concepts.");
        video1.AddComment("Bob", "Interesting video! Looking forward to more content like this.");
        video1.AddComment("Emily", "Very informative. Keep up the good work!");

        video2.AddComment("David", "This was very helpful for beginners like me. Thanks!");
        video2.AddComment("Sarah", "Clear and concise. Can't wait to dive deeper into Python.");
        video2.AddComment("Michael", "Excellent tutorial! Will recommend it to my friends.");

        video3.AddComment("Sophia", "Fascinating stuff! I've always been curious about astrophysics.");
        video3.AddComment("Ethan", "Mind-blowing content! Can't wait to learn more.");
        video3.AddComment("Olivia", "Amazing video! Looking forward to exploring this field further.");

        //Creating a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        //Displaying information about each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.UserName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
