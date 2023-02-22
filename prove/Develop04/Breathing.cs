using System;

public class Breathing : Activity
{
    



    public Breathing()
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking you through a focused breathing exercise. \r\nClear your mind and focus on your breathing.";
        _activityInstructions = "Breathe in through the nose when prompted for the displayed time. \nBreathe out through the mouth when prompted for the displayed time.";
    }

    

    public void BreatheIn()
    {
        Console.WriteLine();
        Console.WriteLine("Breathe in...");
        CountdownTimer(4);
    }

    public void BreatheOut()
    {
        Console.WriteLine();
        Console.WriteLine("Breathe out...");
        CountdownTimer(6);
    }

   
}