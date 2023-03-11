using System;

public class GoalManager
{
    private int _userPoints;
    private List<Goal> _allGoals = new List<Goal>();

    public GoalManager()
    {

    }

    public int GetPoints()
    {
        return _userPoints;
    }

    public void AddGoal(Goal goal)
    {
        _allGoals.Add(goal);
    }

    public List<Goal> GetGoals()
    {
        return _allGoals;
    }

    public void RecordEvent()
    {
        int number = 1;
        Console.WriteLine("Your goals are: ");
        Console.WriteLine();        
        
        foreach (Goal goal in _allGoals)
        {
            Console.Write($"  {number}) ");
            goal.DisplayName();
            number++;
        }
        
        Console.WriteLine();
        Console.Write("Which goal do you want to record an event for? ");
        int eventChoice = int.Parse(Console.ReadLine());
        int points = _allGoals[eventChoice - 1].MarkEvent();
        _userPoints += points;            
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_userPoints);
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
        _userPoints = int.Parse(lines[0]); 
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
            else if (parts[0] == "Checklist")
            {
                ChecklistGoal checklist = new ChecklistGoal();
                checklist.Deserialize(parts);
                AddGoal(checklist);
            }

        }
    }
}


