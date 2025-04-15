using System;  

public class Cycling : Activity  
{  
    private double _speed; // speed in mph  

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)  
    {  
        _speed = speed;  
    }  

    public override double GetDistance() => (_speed / 60) * LengthInMinutes; // Distance in miles  

    public override double GetSpeed() => _speed; // Speed in mph  

    public override double GetPace() => 60 / _speed; // Pace in min per mile  

    public override string GetSummary()  
    {  
        return base.GetSummary() + $" Cycling - Distance {GetDistance():F1} miles, Speed {GetSpeed()} mph, Pace: {GetPace():F2} min per mile";  
    }  
}  