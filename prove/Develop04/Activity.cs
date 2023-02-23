using System;

public class Activity
{
    protected string _activityName;
    protected int _activityDuration;
    protected string _activityDescription;
    protected string _activityInstructions;
    private string[] _pauseAnimations;
    private DateTime _endTime;
    
   
    public Activity()
    {
        _pauseAnimations = new string[] {"|","/","-","\\"};
    }

    
    
    public void ActivityIntro()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity!");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long do you want to do this activity(in seconds)? ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(_activityInstructions);
        Console.WriteLine();
        Console.Write("Press Enter to continue.");
        string start = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseAnimation(2);
    }

    public void StartActivity()
    {   
        ActivityIntro();
        SetEndTime();
    }

    public void EndActivity()
    {
        Console.WriteLine("Well done!");
        PauseAnimation(1);
        Console.WriteLine($"You have completed {_activityDuration} seconds of the {_activityName} Activity.");
        PauseAnimation(1);
        Console.Clear();
    }

    public void CountdownTimer(int time)
    {
        for (int i = time; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }

    public void PauseAnimation(int loop)
    {
        for (int i = 1; i <= loop; i++)
        {
            foreach (string item in _pauseAnimations)
            {
                Console.Write(item);
                Thread.Sleep(750);
                Console.Write("\b \b");
            }
        }
    }

    public void SetEndTime()
    {
        DateTime startTime = DateTime.Now;
        _endTime = startTime.AddSeconds(_activityDuration);
    }

    public DateTime GetEndTime()
    {
        return _endTime;   
    }
}