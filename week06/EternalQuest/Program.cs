using System;  
using System.Collections.Generic;  

namespace EternalQuest  
{  
    // Main program class to manage goals  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            List<Goal> goals = new List<Goal>  
            {  
                new SimpleGoal("Run a marathon"),  
                new EternalGoal("Read scriptures"),  
                new ChecklistGoal("Attend the temple", 10)  
            };  

            // Simulating goal achievements  
            goals[0].RecordEvent(); // Complete Simple Goal  
            goals[1].RecordEvent(); // Record for Eternal Goal  
            goals[2].RecordEvent(); // Record for Checklist Goal  
            goals[2].RecordEvent(); // Record again for Checklist Goal  

            // Displaying all goals and their status  
            Console.WriteLine("\nCurrent Goals and Points:");  
            foreach (var goal in goals)  
            {  
                goal.DisplayGoal();  
            }  

            // Final Checkpoint  
            Console.WriteLine("\nTotal Points:");  
            int totalPoints = 0;  
            foreach (var goal in goals)  
            {  
                totalPoints += goal.GetPoints();  
            }  
            Console.WriteLine($"Total Points Earned: {totalPoints}");  
        }  
    }  
}  