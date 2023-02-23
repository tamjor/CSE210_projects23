using System;

public class Reflection : Activity
{ 
  private string _filenameP;
  private string _filenameQ;
  private List<string> _prompts = new List<string>();
  private List<string> _questions = new List<string>();
  
  // private string _prompt;
  // private string _question;
  private string _item;

  public Reflection()
  {
    _activityName = "Refelction";
    _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
    _activityInstructions = "You will be shown a prompt to consider, then several questions to guide your relfection about the prompt.";
    _filenameP = "ReflectPrompts.txt";
    _filenameQ = "ReflectQuestions.txt";
    
    string[] promptLines = File.ReadAllLines(_filenameP);
    foreach (string line in promptLines)
    {
      _prompts.Add(line);
    }
      
    string[] promptQuestions = File.ReadAllLines(_filenameQ);
    foreach (string line in promptQuestions)
    {
      _questions.Add(line);
    }
  }

  public Reflection(string filenameP, string filenameQ)
  {
    _activityName = "Reflection";
    _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
    _activityInstructions = "You will be shown a prompt to consider, then several questions to guide your relfection about the prompt.";
    _filenameP = filenameP;
    _filenameQ = filenameQ;
      string[] promptLines = File.ReadAllLines(_filenameP);
    foreach (string line in promptLines)
    {
      _prompts.Add(line);
    }
      
    string[] promptQuestions = File.ReadAllLines(_filenameQ);
    foreach (string line in promptQuestions)
    {
      _questions.Add(line);
    }
  }

  // public void SetPrompt()
  // {
  //   if (_prompts.Count == 0)
  //   {
  //     string[] promptLines = File.ReadAllLines(_filenameP);
  //     foreach (string line in promptLines)
  //     {
  //       _prompts.Add(line);
  //     }
  //   }
  //   var randomGen = new Random();
  //   int index = randomGen.Next(_prompts.Count);
  //   _prompt = _prompts[index];
  // }
  // public List<string> GetPrompts()
  // {
  //   return _prompts;
  // }

  // public List<string> GetQuestions()
  // {
  //   return _questions;
  // }

  // public string GetPromptFile()
  // {
  //   return _filenameP;
  // }

  // public string GetQuestionFile()
  // {
  //   return _filenameQ;
  // }
  public void RunReflection(DateTime endTime)
  {
    SetReflectItem(_prompts, _filenameP);
    DisplayReflectItem();
    PauseAnimation(3);
    DateTime currentTime = DateTime.Now;
    while (currentTime < endTime)
    {
      SetReflectItem(_questions, _filenameQ);
      PauseAnimation(2);
      currentTime = DateTime.Now;
    }
  }
  
  public void SetReflectItem(List<string> list, string filename)
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
    _item = list[index];
  }
  
  public void DisplayReflectItem()
  {
    Console.WriteLine(_item);

  }

  // public void DisplayReflectionQuestion()
  // {
    
  // }

}