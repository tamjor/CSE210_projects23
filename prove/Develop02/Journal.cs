// This class handles journal-wide events, like loading and saving files, 
// showing journal entries, and checking file status 

using System;

public class Journal
{
    string _fileName = "";
    public List<Entry> _journalEntries = new List<Entry>();
    public bool _allGood = false;
    public Journal()
    {
    }

    // Displays journal entries to the console.
    public void ShowEntries()
    {
        Console.WriteLine();
        Console.WriteLine("These are your journal entries:");

        foreach (Entry item in _journalEntries)
        {
            Console.WriteLine();
            Console.WriteLine($"Date: {item._date} | Prompt: {item._prompt}");
            Console.WriteLine($"Response: {item._text}");   
        }    
    }
    
    // Loads the user specified .txt file.
    public void Loadfile()
    {
        Console.WriteLine();
        Console.Write("Please enter the .txt file you wish to load: ");
        _fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|'); 

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._text = parts[2];
            _journalEntries.Add(entry);
        }
        Console.WriteLine();
        Console.WriteLine(">> File loaded <<");
    }


    // Validates that the user wants to load a file if there are unsaved journal entries 
    // which would be lost before loading. Any response other than "y" or "Y" will boot 
    // the user back to the menu.
    public void ValidateLoadFile()
    {
        if (_journalEntries.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Warning: Loading a new file will overwrite any unsaved journal entries!");
            Console.Write("Do you wish to continue? (Y/N)  ");
            string userInput = Console.ReadLine();
            
            if (userInput == "Y" || userInput == "y")
            {
                _journalEntries.Clear();
                Loadfile();
            }
        }

        else
        {
            Loadfile();    
        }
    }

    // Saves the journal entries to a user specified .txt file
    public void SaveFile()
    {
        using (FileStream stream = File.Open(_fileName, FileMode.Create))
        {
            using (StreamWriter outputFile = new StreamWriter(stream))
            {
                foreach (Entry item in _journalEntries)
                {
                    string strItem = $"{item._date}|{item._prompt}|{item._text}";
                    outputFile.WriteLine(strItem);
                }  
            }
        }
        Console.WriteLine();
        Console.WriteLine(">> File saved <<"); 
    }

    // Validates that the user wants to save to the specified location if a pre-existing 
    // file is detected at that location before saving.  Any response other than "y" or "Y" 
    // will boot the user back to the menu.
    public void ValidateSaveFile()
    {
        Console.WriteLine();
        Console.Write("Please enter the .txt file name: ");
        _fileName = Console.ReadLine();
        
        if (File.Exists(_fileName))
        {
            Console.WriteLine();
            Console.WriteLine("Warning: This will overwrite the existing file at this location!");
            Console.Write("Do you wish to continue? (Y/N)  ");
            string userInput = Console.ReadLine();
            if (userInput == "Y" || userInput == "y")
            {
                 SaveFile();
            }
        }
        else
        {
            SaveFile();
        }   
    }

    // Checks if the journal and all entries have been saved prior to closing the program
    //  and gives the user the opportunity to abort the quit action. Any response other 
    // than "y" or "Y" will boot the user back to the menu.
    public void CheckFile()
    {
        if (string.IsNullOrWhiteSpace(_fileName))
        {    
            Console.WriteLine();
            Console.Write("You have not saved your journal yet. Are you sure you want to quit? (Y/N)  ");         
        }

        else
        {
            string[] lines = System.IO.File.ReadAllLines(_fileName);

            if (lines.Length != _journalEntries.Count)
            {
                Console.WriteLine();
                Console.Write("You have unsaved journal entries. Are you sure you want to quit? (Y/N)  ");
            }

            else if (lines.Length == _journalEntries.Count)
            {
                _allGood = true;   
            }
        }
    }

}