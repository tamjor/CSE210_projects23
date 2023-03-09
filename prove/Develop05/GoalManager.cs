using System;

public class GoalManager
{
    private int _userPoints;
    private DateTime _date = DateTime.Now;
    private List<Goal> _allGoals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        _allGoals.Add(goal);
    }

    public List<Goal> GetGoals()
    {
        return _allGoals;
    }

    public void Serialize()
    {
        
    }

    public void Deserialize()
    {

    }

    
}


