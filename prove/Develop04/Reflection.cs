using System;

public class Reflection : Activity
{
    private string _filenameP;
    private string _filenameQ;
    private List<string> _prompts;
    private List<string> _questions;

      public Reflection()
    {
        _activityName = "Refelction";
        _activityDescription = "";
        _activityInstructions = "";
        _filenameP = "";
        _filenameQ = "";
        // add lines from file to Lists
    }

      public Reflection(string filenameP, string filenameQ)
    {
        _activityName = "Reflection";
        _activityDescription = "";
        _activityInstructions = "";
        _filenameP = filenameP;
        _filenameQ = filenameQ;
        // add lines from file to Lists
    }

    public void SetPrompt()
    {

    }

    public void SetQuestion()
    {

    }
    public void DisplayReflectionPrompt()
    {

    }

    public void DisplayReflectionQuestion()
    {
      
    }

}