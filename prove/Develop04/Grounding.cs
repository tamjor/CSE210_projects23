using System;

public class Grounding : Activity
{
    private string[] foci = {"hear" , "touch" , "see"};

    public Grounding()
    {
        _activityName = "Grounding";
        _activityDescription = "This activity will help ground you by having you focus on your surroundings.";
        _activityInstructions = "Focus on your surroundings by following the prompts you will be shown.";
    }

    public void DisplayGroundPrompts ()
    {
        for (int i = 0; i < foci.Length; i++)  
        {
            int loop = 2;
            Console.WriteLine();
            Console.WriteLine($"--- Name {i + 1} thing(s) you can {foci[i]}. ---");
            PauseAnimation(loop++);
        }
    }

    public void RunGrounding()
    {
        StartActivity();
        SetEndTime();
        while (DateTime.Now < _endTime)
        {
            DisplayGroundPrompts();
            
        }
        EndActivity();
    }



}