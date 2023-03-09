using System;

public class SimpleGoal : Goal
{   private string _showcomplete;
    public SimpleGoal() : base()
    {
        _goalType = "Simple"; 
        _isComplete = false;
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
        if (_isComplete == false)
        {
            _showcomplete = " ";
            Console.WriteLine($"[{_showcomplete}] {_goalName} ({_goalDescription})");
        }
        else if (_isComplete == true)
        {
            _showcomplete = "x";
            Console.WriteLine($"[{_showcomplete}] {_goalName} ({_goalDescription})");
        }
    }
    
    public override void RecordEvent()
    {

    }

   

    

}