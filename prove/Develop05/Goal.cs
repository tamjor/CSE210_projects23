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
    
    public abstract void RecordEvent();

    public abstract void IsComplete();

    public abstract void DisplayGoal();
    
    


}