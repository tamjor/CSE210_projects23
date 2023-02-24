using System;

public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private string _prompt;
    private int _responseQuantity;
    private string _filename;
    public Listing()
    {
        _activityName = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _activityInstructions = "You will be shown a prompt to respond to. Once you have finished, a new prompt will be shown until the specified time has elapsed.";
        _filename ="ListingPrompts.txt";
        _responseQuantity = 0;
        string[] lines = File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
    }

    public Listing(string filename)
    {
        _activityName = "Listing";
        _activityDescription = "";
        _activityInstructions = "";
        _filename = filename;
        _responseQuantity = 0;
        string[] lines = File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
    }

    public void RunListing()
    {
        StartActivity();
        SetEndTime();
        while (DateTime.Now < _endTime)
        {
            SetPrompt();
            DisplayListingPrompt();
        }
        DisplayResponseQuantity();
        EndActivity();
    }

    public void SetPrompt()
    {
        if (_prompts.Count == 0)
        {
        string[] lines = File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
        }
        var randomGen = new Random();
        int index = randomGen.Next(_prompts.Count);
        _prompt = _prompts[index];
        _prompts.RemoveAt(index);
    }
    public void DisplayListingPrompt()
    {
        Console.Write(">> ");
        Console.WriteLine(_prompt);
        Console.ReadLine();
        Console.WriteLine();
        _responseQuantity += 1;
    }
    public void DisplayResponseQuantity()
    {
        Console.WriteLine();
        Console.WriteLine($"You responded to {_responseQuantity} prompts in {_activityDuration} seconds.");
        PauseAnimation(2);
    }
}