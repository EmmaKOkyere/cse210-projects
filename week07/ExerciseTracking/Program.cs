using System;  
using System.Collections.Generic;  

class Program  
{  
    static void Main(string[] args)  
    {  
        // Create a list to hold the activities  
        List<Activity> activities = new List<Activity>  
        {  
            new Running(new DateTime(2022, 11, 3), 30, 3.0), // 3 miles  
            new Cycling(new DateTime(2022, 11, 4), 45, 15.0), // 15 mph  
            new Swimming(new DateTime(2022, 11, 5), 20, 30)    // 30 laps  
        };  

        // Iterate through the activities and display each summary  
        foreach (var activity in activities)  
        {  
            Console.WriteLine(activity.GetSummary());  
        }  
    }  
}  