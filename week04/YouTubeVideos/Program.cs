// Program.cs  
using System;  
using System.Collections.Generic;  

class Program  
{  
    static void Main(string[] args)  
    {  
     
        List<Video> videos = new List<Video>();  

        
        Video video1 = new Video("Understanding Abstraction in C#", "Emmanuel Okyere", 300);  
        video1.AddComment(new Comment("Abby", "Great explanation!"));  
        video1.AddComment(new Comment("Evans", "This is informative."));  
        video1.AddComment(new Comment("Stephanie", "Thanks for sharing that!"));  

        Video video2 = new Video("Introduction to OOP", "Ebenezer Okyere", 420);  
        video2.AddComment(new Comment("David", "I am learning a lot!"));  
        video2.AddComment(new Comment("Udy", "I can't wait for the next part."));  
        video2.AddComment(new Comment("Frank", "this is a helpful video, thank you!"));  

        Video video3 = new Video("C# Programming for Beginners", "Isaac Okyere", 540);  
        video3.AddComment(new Comment("Grace", "This is perfect for newbies and beginners."));  
        video3.AddComment(new Comment("Hannah", "I would appreciate more content like this please."));  
        video3.AddComment(new Comment("Jane", "Well explained!"));  

     
        videos.Add(video1);  
        videos.Add(video2);  
        videos.Add(video3);  

     
        foreach (var video in videos)  
        {  
            Console.WriteLine($"Title: {video.Title}");  
            Console.WriteLine($"Author: {video.Author}");  
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");  
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");  
            Console.WriteLine("Comments:");  
            foreach (var comment in video.GetComments())  
            {  
                Console.WriteLine($" - {comment}");  
            }  
            Console.WriteLine();  
        }  
    }  
}  



