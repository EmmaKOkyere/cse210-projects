using System;  

public class Swimming : Activity  
{  
    private int _laps;  

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)  
    {  
        _laps = laps;  
    }  

    public override double GetDistance() => _laps * 50 / 1000.0; // Distance in km  

    public override double GetSpeed() => (GetDistance() / LengthInMinutes) * 60; // Speed in kph  

    public override double GetPace() => LengthInMinutes / GetDistance(); // Pace in min per km  

    public override string GetSummary()  
    {  
        return base.GetSummary() + $" Swimming - Distance {GetDistance():F2} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";  
    }  
}  