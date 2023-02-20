using System;

public class Activity
{
    protected string _activityName;
    protected int _activityDuration;
    protected string _activityDescription;
    protected string _activityInstructions;
   

    
    public int GetActivityDuration()
    {
        return _activityDuration;
    }
    public void ActivityReady()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity!");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long do you want to do this activity(in seconds)? ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }

    public void CountdownTimer(int time)
    {
        for (int i = time; i >= 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b  \b\b");
            }
    }

    public void PauseAnimation(int time)
    {

    }

    public void BeginActivity(int time)
    {
        CountdownTimer(time);
        Console.WriteLine();
        Console.WriteLine(_activityInstructions);

    }

    public void ActivtityTimer()
    {

    }

    
}