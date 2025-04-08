namespace EternalQuest  
{  
    // Class for eternal goals  
    public class EternalGoal : Goal  
    {  
        private int CompletionCount;  

        public EternalGoal(string name) : base(name)  
        {  
            CompletionCount = 0;  
            Points = 100; // Points for each completion  
        }  

        public override void RecordEvent()  
        {  
            CompletionCount++;  
            Console.WriteLine($"Goal '{Name}' recorded! You earned {Points} points.");  
        }  

        public override int GetPoints()  
        {  
            return CompletionCount * Points;  
        }  

        public override void DisplayGoal()  
        {  
            Console.WriteLine($"[Eternal Goal] {Name} - Completed {CompletionCount} times, Total Points: {GetPoints()}");  
        }  
    }  
}  