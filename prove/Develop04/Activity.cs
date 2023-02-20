using System;

public class Activity
{
    protected string _activityName;
    protected int _activityDuration;
    protected string _activityDescription;
    protected string _activityInstructions;
    private string[] _pauseAnimations = {"|","/","-","\\"};
    protected bool _done = false;

    public Activity()
    {
        
    }

    
    public int GetActivityDuration()
    {
        return _activityDuration;
    }
    public void ReadyActivity()
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
                Console.Write("\b  \b");
            }
    }

    public void PauseAnimation(int time)
    {
        for (int i = time; i >= 0; i--)
        {
            foreach (string item in _pauseAnimations)
            {
                Console.Write(item);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }

    public void BeginActivity(int time)
    {
        CountdownTimer(time);
        Console.WriteLine();
        Console.WriteLine(_activityInstructions);

    }

    public bool GetDone()
    {
        return _done;
    }
    public void ActivtityTimer()
    {
        for (int i =_activityDuration; i >= 0; i--)
        {
            Thread.Sleep(1000);
            if (i == 0)
            {
                _done = true;
            }
        }
    }

    public void EndActivity()
    {
        Console.WriteLine("Well done!");
        PauseAnimation(5);
        Console.WriteLine($"You have completed {_activityDuration} seconds of the {_activityName} Activity.");
        PauseAnimation(8);
    }

    
}