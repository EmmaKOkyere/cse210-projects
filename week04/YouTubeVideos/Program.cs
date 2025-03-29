using System;  
using System.Collections.Generic;  

public class Program  
{  
    public static void Main(string[] args)  
    {  
        // Create a list of videos  
        List<Video> videos = new List<Video>();  

        // Create first video  
        Video video1 = new Video("Fun Coding Tutorial", "Coder123", 300);  
        video1.AddComment(new Comment("User1", "Great video!"));  
        video1.AddComment(new Comment("User2", "Very informative!"));  
        video1.AddComment(new Comment("User3", "Loved it!"));  

        // Add video to the list  
        videos.Add(video1);  

        // Create second video  
        Video video2 = new Video("Understanding Abstraction", "TechGuru", 450);  
        video2.AddComment(new Comment("User4", "Nice explanation!"));  
        video2.AddComment(new Comment("User5", "Helped me a lot!"));  

        // Add video to the list  
        videos.Add(video2);  

        // Create third video  
        Video video3 = new Video("OOP Basics", "LearnWithMe", 600);  
        video3.AddComment(new Comment("User6", "Clear and concise!"));  
        video3.AddComment(new Comment("User7", "Looking forward to more!"));  
        video3.AddComment(new Comment("User8", "This was well done."));  

        // Add video to the list  
        videos.Add(video3);  

        // Create fourth video  
        Video video4 = new Video("Advanced C# Features", "DevMaster", 1200);  
        video4.AddComment(new Comment("User9", "Amazing content!"));  
        video4.AddComment(new Comment("User10", "Thanks for sharing!"));  

        // Add video to the list  
        videos.Add(video4);  

        // Display video information  
        foreach (var video in videos)  
        {  
            video.DisplayVideoInfo();  
        }  
    }  
}  