using System;

public class GoalManager
{
    private int _userPoints;
    private List<Goal> _allGoals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        _allGoals.Add(goal);
    }

    public List<Goal> GetGoals()
    {
        return _allGoals;
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _allGoals)
            {
                string item = goal.Serialize();
                outputFile.WriteLine(item);
                
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts[0] == "Simple")
            {
                SimpleGoal simple = new SimpleGoal();
                simple.Deserialize(parts);
                AddGoal(simple);

            }
            else if (parts[0] == "Eternal")
            {
                EternalGoal eternal = new EternalGoal();
                eternal.Deserialize(parts);
                AddGoal(eternal);
            }
            else if (parts[0] == "Checkpoint")
            {
                CheckpointGoal checkpoint = new CheckpointGoal();
                checkpoint.Deserialize(parts);
                AddGoal(checkpoint);
            }

        }
    }
}


