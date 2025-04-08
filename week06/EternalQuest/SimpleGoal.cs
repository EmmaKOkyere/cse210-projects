namespace EternalQuest  
{  
    // Class for simple goals  
    public class SimpleGoal : Goal  
    {  
        private bool IsCompleted;  

        public SimpleGoal(string name) : base(name)  
        {  
            IsCompleted = false;  
            Points = 1000; // Fixed points for completing this goal  
        }  

        public override void RecordEvent()  
        {  
            IsCompleted = true;  
            Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");  
        }  

        public override int GetPoints()  
        {  
            return IsCompleted ? Points : 0;  
        }  

        public override void DisplayGoal()  
        {  
            string status = IsCompleted ? "Completed" : "Not Completed";  
            Console.WriteLine($"[Simple Goal] {Name} - Status: {status}, Points: {GetPoints()}");  
        }  
    }  
}  