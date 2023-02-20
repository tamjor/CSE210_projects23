using System;

public class Breathing : Activity
{
    



    public Breathing()
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. \r\nClear your mind and focus on your breathing.";
        _activityInstructions = "Breathe in, breathe out.";
    }

    

    public void BreatheIn()
    {
        Console.WriteLine();
        Console.Write("Breathe in...");
        CountdownTimer(5);
        Console.WriteLine();
    }

    public void BreatheOut()
    {
        Console.WriteLine();
        Console.Write("Breathe out...");
        CountdownTimer(8);
        Console.WriteLine();
    }

   
}