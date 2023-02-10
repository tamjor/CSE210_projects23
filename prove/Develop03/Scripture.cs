using System;
using System.IO;

public class Scripture
{
    private Dictionary<string, string> _verses = new Dictionary<string, string>();
    private string _fileName = "scriptures.txt";
    private string _verse;
    private string _reference;

// populates the _verses dictionary from a .txt file when the class is instantiated
    public Scripture(string reference)
    {
        string[] lines = File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string key = parts[0];
            string value = parts[1];
            _verses.Add(key, value);            
        }

        _reference = reference;
    
    }


    public void SetVerse()
    {
        _verse = _verses[_reference];
    }
    public string GetVerse()
    {
        return _verse;
    }
}











