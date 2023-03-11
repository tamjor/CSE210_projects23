using System;

public class EternalGoal : Goal
{
    private string _eternalGoalString;

    public EternalGoal() : base()
    {
        _goalType = "Eternal";
    }

    public override void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Let's create a new eternal goal!");
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
        return _goalPoints;
    }

    public override void DisplayName()
    {
        Console.WriteLine($"{_goalName}");
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_goalName}({_goalPoints}pts) ({_goalDescription})");
    }

    public override string Serialize()
    {
        return _eternalGoalString = $"{_goalType},{_goalName},{_goalDescription},{_goalPoints},{_isComplete}";
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
