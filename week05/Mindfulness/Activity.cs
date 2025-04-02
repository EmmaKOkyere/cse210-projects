using System;

public abstract class Activity
{
    protected int duration;

    public void StartMessage(string description)
    {
        Console.WriteLine($"Starting Activity: {description}");
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Pause(3);
    }

    public void EndMessage(string activityName)
    {
        Console.WriteLine($"Good job! You've completed the {activityName} for {duration} seconds.");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Pausing... {i}");
            System.Threading.Thread.Sleep(1000);
        }
    }

    public abstract void Execute();
}