using System;

public class BreathingActivity : Activity
{
    public override void Execute()
    {
        StartMessage("Breathing Activity: This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        for (int i = 0; i < duration; i += 4)
        {
            Console.WriteLine("Breathe in...");
            Pause(4); // Breathing in for 4 seconds
            Console.WriteLine("Breathe out...");
            Pause(4); // Breathing out for 4 seconds
        }

        EndMessage("Breathing Activity");
    }
}