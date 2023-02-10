using System;

using System.IO;

public class Reference
{
    private string _reference;
    private List<string> _references = new List<string>();
    private string _fileName = "scriptures.txt";

// populates the _references list from a .txt file when the class is instantiated
    public Reference()
    {
        string[] lines = File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string key = parts[0];
            _references.Add(key);            
        }
    }

    public void SetReference()
    {
        var randomGen = new Random();
        int refIndex = randomGen.Next(_references.Count);
        _reference = _references[refIndex];
    }
    public string GetReference()
    {    
        return _reference;
    }

    public void DisplayReference()
    {
        Console.WriteLine(_reference);
    }
}

