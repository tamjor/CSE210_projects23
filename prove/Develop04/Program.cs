using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathe = new Breathing();
        breathe.ActivityReady();
        int duration = breathe.GetActivityDuration();
        Console.WriteLine($"You have entered {duration}");
    }
}