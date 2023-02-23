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
        Console.WriteLine("Breathe in...");
        CountdownTimer(4);
    }

    public void BreatheOut()
    {
        Console.WriteLine();
        Console.WriteLine("Breathe out...");
        CountdownTimer(6);
    }

    public void RunBreathing(DateTime endTime)
    {
        Console.WriteLine("Running breathing activity.");
        DateTime currentTime = DateTime.Now;
        // Console.WriteLine($"current time is {currentTime}.");
        // Console.WriteLine($"end time is {endTime}");
        // PauseAnimation(1);
        while (currentTime < endTime)
        {
            BreatheIn();
            BreatheOut();
            currentTime = DateTime.Now;
        }
    }
}