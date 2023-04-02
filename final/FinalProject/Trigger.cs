using System;

public class Trigger
{
    protected string _triggerType;
    protected string _triggerDescription;
    protected string _triggerOccurance;


    public void LogTrigger()
    {
        Menu menu = new Menu("trigger"); 
        
        Console.WriteLine();    
        Console.Write("What type of trigger would you like to add? ");
        
        menu.DisplayMenu();
        int typeChoice = menu.GetUserChoice();
        
        if (typeChoice == 1)
            _triggerType = "Activity";
        
        else if (typeChoice == 2)
            _triggerType = "Environmental";
        
        else if (typeChoice == 3)
            _triggerType = "Food";
        
        else if (typeChoice == 4)
            _triggerType = "Medicine";

        Console.Clear();
        Console.WriteLine();
        Console.Write($"Give a brief description of the {_triggerType} trigger: ");
        _triggerDescription = Console.ReadLine();
        
        Console.WriteLine();
        Console.Write($"When did the {_triggerType} trigger occur(MM/DD/HH/MM)? ");
        _triggerOccurance = Console.ReadLine();
    } 
    
    public string Serialize()
    {
        return $"{_triggerType}|{_triggerDescription}|{_triggerOccurance}";
    }

    public void Deserialize(string[] trigger)
    {
        _triggerType = trigger[0];
        _triggerDescription = trigger[1];
        _triggerOccurance = trigger[2];
    }

    public void DisplayTrigger()
    {
        Console.WriteLine();
        Console.WriteLine($"    >>Trigger<<\n    Type: {_triggerType}\n    Description: {_triggerDescription}\n    Occurance: {_triggerOccurance}");
    }
}