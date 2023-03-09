using System;

public class CheckpointGoal : Goal
{
    private int _currentNumber;
    private int _goalNumber;

    public CheckpointGoal() : base()
    {
       
    }

    public override void CreateGoal()
    {
        Console.Clear();
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        _goalDescription = Console.ReadLine();
        Console.Write("How many points will be associated with this goal?");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    public override void IsComplete()
    {
        _isComplete = true;
    }

    public override void DisplayGoal()
    {

    }
    
    public override void RecordEvent()
    {
        
    }

}