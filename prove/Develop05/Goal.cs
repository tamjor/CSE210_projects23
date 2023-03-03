using System;

public abstract class Goal
{
    private int _userPoints;
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private string _date;
    private Dictionary<string, string> _goals = new Dictionary<string, string>();

    public void SaveToFile()
    {

    }

    public void LoadFromFile()
    {

    }

    public void Serialize()
    {

    }

    public void Deserialize()
    {

    }

    public abstract void CreateGoal();

    public abstract void RecordEvent();

    public abstract void IsComplete();

    public abstract void DisplayGoalList();



}