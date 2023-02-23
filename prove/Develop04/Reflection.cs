using System;

public class Reflection : Activity
{ 
  private string _filenameP;
  private string _filenameQ;
  private List<string> _prompts = new List<string>();
  private List<string> _questions = new List<string>();
  private string _item;

  public Reflection()
  {
    _activityName = "Reflection";
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
    list.RemoveAt(index);
  }
  
  public void DisplayReflectItem()
  {
    Console.Write(_item);
  }

  public void RunReflection()
  {
    Console.WriteLine();
    SetReflectItem(_prompts, _filenameP);
    Console.Write("-- ");
    DisplayReflectItem();
    Console.Write(" --");
    Console.WriteLine();
    PauseAnimation(3);
    SetEndTime();
    while (DateTime.Now < _endTime)
    {
      Console.WriteLine();
      SetReflectItem(_questions, _filenameQ);
      Console.Write("  ");
      DisplayReflectItem();
      Console.Write("  ");
      PauseAnimation(3);
      Console.WriteLine();
    }
  }

}