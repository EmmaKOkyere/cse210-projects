using System;  

public class Running : Activity  
{  
    private double _distance; // in miles  

    public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)  
    {  
        _distance = distance;  
    }  

    public override double GetDistance() => _distance;  

    public override double GetSpeed() => (_distance / LengthInMinutes) * 60; // Speed in mph  

    public override double GetPace() => LengthInMinutes / _distance; // Pace in minutes per mile  

    public override string GetSummary()  
    {  
        return base.GetSummary() + $" Running - Distance {GetDistance()} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";  
    }  
}  