using System;

public abstract class Goal
{
    protected string _goalType; 
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints; 
    protected bool _isComplete;
    
    public Goal()
    {
       
    }
   
    public abstract void CreateGoal();

    public abstract int MarkEvent();

    public abstract void DisplayGoal();

    public abstract void DisplayName();

    public abstract string Serialize();

    public abstract void Deserialize(string[] goal);
}