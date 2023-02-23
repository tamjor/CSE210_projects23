using System;

public class Activity
{
    protected string _activityName;
    protected int _activityDuration;
    protected string _activityDescription;
    protected string _activityInstructions;
    private string[] _pauseAnimations;
    protected DateTime _endTime;
    
   
    public Activity()
    {
        _pauseAnimations = new string[] {"|","/","-","\\"};
    }

    
    
    public void StartActivity()
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
        Console.Write("    ");
        PauseAnimation(2);
        Console.WriteLine();
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.Write("    ");
        PauseAnimation(2);
         Console.WriteLine();
        Console.WriteLine($"You have completed {_activityDuration} seconds of the {_activityName} Activity.");
        Console.Write("    ");
        PauseAnimation(3);
        Console.Clear();
    }

     public void SetEndTime()
    {
        DateTime startTime = DateTime.Now;
        _endTime = startTime.AddSeconds(_activityDuration);
    }

    public void CountdownTimer(int time)
    {
        for (int i = time; i > 0; i--)
            {
                Console.Write($"\b{i}");
                Thread.Sleep(1000);
            }
        Console.Write($"\b \b");
    }

    public void PauseAnimation(int loop)
    {
        for (int i = 1; i <= loop; i++)
        {
            foreach (string item in _pauseAnimations)
            {
                Console.Write($"\b{item}");
                Thread.Sleep(500);
            }
        }
        Console.Write($"\b \b");
    }

   
}