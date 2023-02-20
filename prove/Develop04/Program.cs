using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathe = new Breathing();
        breathe.ReadyActivity();
        // int duration = breathe.GetActivityDuration(); //for testing purposes
        // Console.WriteLine($"You have entered {duration}"); //for testing purposes

        breathe.BeginActivity(5);
        breathe.ActivtityTimer();
        for (bool done = false; done == false; done = breathe.GetDone())
        {
            breathe.BreatheIn();
            breathe.BreatheOut();
        }
        breathe.EndActivity();
    }
}