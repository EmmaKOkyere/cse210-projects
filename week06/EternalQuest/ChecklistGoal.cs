namespace EternalQuest  
{  
    // Class for checklist goals  
    public class ChecklistGoal : Goal  
    {  
        private int CompletionCount;  
        private int RequiredCount;  

        public ChecklistGoal(string name, int requiredCount) : base(name)  
        {  
            CompletionCount = 0;  
            RequiredCount = requiredCount;  
            Points = 50; // Points for each completion  
        }  

        public override void RecordEvent()  
        {  
            CompletionCount++;  
            Console.WriteLine($"Goal '{Name}' recorded! You earned {Points} points.");  
        }  

        public override int GetPoints()  
        {  
            int totalPoints = CompletionCount * Points;  
            if (CompletionCount >= RequiredCount)  
            {  
                totalPoints += 500; // Bonus points for completing the checklist  
            }  
            return totalPoints;  
        }  

        public override void DisplayGoal()  
        {  
            Console.WriteLine($"[Checklist Goal] {Name} - Completed {CompletionCount}/{RequiredCount} times, Total Points: {GetPoints()}");  
        }  
    }  
}  