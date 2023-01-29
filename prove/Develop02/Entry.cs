// This class provides a writing prompt, declares and assigns the entry variables.

using System;

public class Entry
{
    public string _text = "";
    public List<string> _prompts = new List<string>();
    public string _prompt = "";
    public string _date = "";
    
    public Entry()
    {
    }

    // Gets a random writing prompt from the prompt file and displays it to the console.
    public void DisplayPrompt()
    {
        string[] _lines = System.IO.File.ReadAllLines("journal-prompts.txt");
        foreach (string line in _lines)
        {
            _prompts.Add(line);
        }
        
        var randomGen = new Random();
        int promptIndex = randomGen.Next(_prompts.Count);
        _prompt = _prompts[promptIndex];
        Console.WriteLine();
        Console.WriteLine(_prompt);
    }

    // Gets the date and user response to a writing prompt.
    public void GetResponse()
    {
        _date = DateTime.Now.ToShortDateString();
        Console.Write(">> ");
        _text = Console.ReadLine();
    }

}