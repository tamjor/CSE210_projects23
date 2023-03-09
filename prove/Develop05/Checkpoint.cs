using System;

public class CheckpointGoal : Goal
{
    private int _currentNumber;
    private int _goalNumber;
    private int _bonusPoints;
    private string _showcomplete;
    private string _checkpointGoalString;

    public CheckpointGoal() : base()
    {
       _goalType = "Checkpoint";
    }

    public override void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Let's create a new checkpoint goal!");
        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        _goalDescription = Console.ReadLine();
        Console.Write("How many points will be associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished to receive bonus points? ");
        _goalNumber = int.Parse(Console.ReadLine());
        Console.Write($"What is the bonus for completing this goal {_goalNumber} times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
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
            Console.WriteLine($"[{_showcomplete}] {_goalName} ({_goalDescription}) -- Completed {_currentNumber} of {_goalNumber} times.");
        }

        else if (_isComplete == true)
        {
            _showcomplete = "X";
            Console.WriteLine($"[{_showcomplete}] {_goalName} ({_goalDescription}) -- Completed {_currentNumber} of {_goalNumber} times.");
        }
    }

    public override void RecordEvent()
    {
        
    }

    public override string Serialize()
    {
        return _checkpointGoalString = $"{_goalType}, {_goalName}, {_goalDescription}, {_currentNumber}, {_goalNumber}, {_goalPoints}, {_isComplete}";
    }

    public override void Deserialize(string[] goal)
    {
        _goalType = goal[0];
        _goalName = goal[1];
        _goalDescription = goal[2];
        _currentNumber = int.Parse(goal[3]);
        _goalNumber = int.Parse(goal[4]);
        _goalPoints = int.Parse(goal[5]);
        _isComplete = bool.Parse(goal[6]);
    }

}