using System;  

public abstract class Activity  
{  
    // Attributes  
    private DateTime _date;  
    private int _lengthInMinutes;  

    // Constructor  
    protected Activity(DateTime date, int lengthInMinutes)  
    {  
        _date = date;  
        _lengthInMinutes = lengthInMinutes;  
    }  

    // Properties  
    public DateTime Date => _date;  
    public int LengthInMinutes => _lengthInMinutes;  

    // Abstract methods to be implemented in derived classes  
    public abstract double GetDistance();  
    public abstract double GetSpeed();  
    public abstract double GetPace();  

    // GetSummary method  
    public virtual string GetSummary()  
    {  
        return $"{_date:dd MMM yyyy} ({LengthInMinutes} min)";  
    }  
}  