using System;

public class Reflection : Activity
{
    private string _filenameP;
    private string _filenameQ;
    private List<string> _prompts;
    private List<string> _questions;
    private string _prompt;
    private string _question;

    public Reflection()
    {
      _activityName = "Refelction";
      _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
      _activityInstructions = "You will be shown a prompt to consider, then several questions to guide your relfection about the prompt. ";
      _filenameP = "ReflectPrompts.txt";
      _filenameQ = "ReflectQuestions.txt";
    }

    public Reflection(string filenameP, string filenameQ)
    {
      _activityName = "Reflection";
      _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
      _activityInstructions = "";
      _filenameP = filenameP;
      _filenameQ = filenameQ;
    }

    public void SetPrompt()
    {
      if (_prompts.Count == 0)
      {
        string[] promptLines = File.ReadAllLines(_filenameP);
        foreach (string line in promptLines)
        {
          _prompts.Add(line);
        }
      }
      var randomGen = new Random();
      int index = randomGen.Next(_prompts.Count);
      _prompt = _prompts[index];
    }

    public void SetQuestion(List<string> list, string filename, string item )
    {
      if (list.Count == 0)
      {
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
          list.Add(line);
        }
      }
      var randomGen = new Random();
      int index = randomGen.Next(list.Count);
      item = list[index];
    }
    
    public void DisplayPrompt()
    {

    }

    public void DisplayReflectionQuestion()
    {
      
    }

}