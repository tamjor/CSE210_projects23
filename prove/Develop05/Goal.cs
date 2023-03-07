using System;

public abstract class Goal
{
    protected int _userPoints;
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected string _date; 
    protected bool _isComplete;
    protected Dictionary<string, string> _goals = new Dictionary<string, string>();

    public Goal()
    {
        File file = new File();
    }
   

    public abstract void CreateGoal();

    public abstract void RecordEvent();

    public abstract void IsComplete();

    public abstract void DisplayGoalList();



}