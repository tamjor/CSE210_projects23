using System;

public class Breathing : Activity
{
    
    public Breathing()
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking you through a focused breathing exercise. \r\nClear your mind and focus on your breathing.";
        _activityInstructions = "Breathe in through the nose when prompted. \nBreathe out through the mouth when prompted.";
    }

    public void BreatheIn()
    {
        Console.WriteLine();
        Console.Write("Breathe in...  ");
        CountdownTimer(4);
        Console.WriteLine();
    }

    public void BreatheOut()
    {
        Console.WriteLine();
        Console.Write("Breathe out...  ");
        CountdownTimer(6);
        Console.WriteLine();
    }

    public void RunBreathing()
    {
        StartActivity();
        SetEndTime();
        while (DateTime.Now < _endTime)
        {
            BreatheIn();
            BreatheOut();
        }
        EndActivity();
    }
}