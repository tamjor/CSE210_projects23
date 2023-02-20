using System;

public class Listing : Activity
{
    private List<string> _prompts;
    private string _prompt;
    private int _responseQuantity;
    private string _filename;
    public Listing()
    {
        _activityName = "Listing";
        _activityDescription = "";
        _activityInstructions = "";
        _filename ="";
        // add prompts from file to _prompts List
    }

    public Listing(string filename)
    {
        _activityName = "Listing";
        _activityDescription = "";
        _activityInstructions = "";
        _filename = filename;
        // add prompts from file to _prompts List
    }

    public void SetPrompt()
    {

    }
    public void DisplayListingPrompt()
    {

    }
    public void DisplayResponseAmount()
    {

    }

    public void DisplayResponseQuantity()
    {

    }
}