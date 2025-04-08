namespace EternalQuest  
{  
    // Abstract base class for all goals  
    public abstract class Goal  
    {  
        protected string Name;  
        protected int Points;  

        public Goal(string name)  
        {  
            Name = name;  
        }  

        public abstract void RecordEvent(); // Abstract method for recording achieving a goal  
        public abstract int GetPoints();     // Abstract method for getting the points for the goal  
        public abstract void DisplayGoal();   // Abstract method to display goal information  
    }  
}  