using System;

public class SimpleGoal : Goal
{   private string _showcomplete;
    private string _simpleGoalString;
    
    public SimpleGoal() : base()
    {
        _goalType = "Simple"; 
        _isComplete = false;
    }

    public override void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Let's create a new simple goal!");
        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        _goalDescription = Console.ReadLine();
        Console.Write("How many points will be associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    public override int MarkEvent()
    {
        _isComplete = true;
        return _goalPoints;
    }

    public override void DisplayGoal()
    {
        if (_isComplete == false)
        {
            _showcomplete = " ";
            
        }
        else if (_isComplete == true)
        {
            _showcomplete = "X";
        }
        Console.WriteLine($"[{_showcomplete}] {_goalName} ({_goalDescription})");
    }

    public override void DisplayName()
    {
        Console.WriteLine($"{_goalName}");
    }

    public override string Serialize()
    {
        return _simpleGoalString = $"{_goalType}, {_goalName}, {_goalDescription}, {_goalPoints}, {_isComplete}";
    }

    public override void Deserialize(string[] goal)
    {
        _goalType = goal[0];
        _goalName = goal[1];
        _goalDescription = goal[2];
        _goalPoints = int.Parse(goal[3]);
        _isComplete = bool.Parse(goal[4]);
    }
}