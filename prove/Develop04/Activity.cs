using System;

public class Activity
{
    protected string _activityName;
    protected int _activityDuration;
    protected string _activityDescription;
    protected string _activityInstructions;
    private string[] _pauseAnimations;
    
   
    public Activity()
    {
        _pauseAnimations = new string[] {"|","/","-","\\"};
    }

    
    
    public void BeginActivity()
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
        PauseAnimation(5);
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    

    public void EndActivity()
    {
        Console.WriteLine("Well done!");
        PauseAnimation(5);
        Console.WriteLine($"You have completed {_activityDuration} seconds of the {_activityName} Activity.");
        PauseAnimation(8);
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

    public void PauseAnimation(int time)
    {
        for (int i = time; i >= 0; i--)
        {
            foreach (string item in _pauseAnimations)
            {
                Console.Write(item);
                Thread.Sleep(350);
                Console.Write("\b \b");
            }
        }
    }
}