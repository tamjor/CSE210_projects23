using System;

public class Trigger
{
    protected string _triggerType;
    private string _triggerIntensity;
    protected string _triggerDescription;
    protected string _triggerOccurance;


    public void LogTrigger()
    {
        Menu menu = new Menu("trigger");     
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

        Console.Write("How would you rank the intensity of this trigger on a scale of 1 to 10? ");
        _triggerIntensity = Console.ReadLine();
        Console.Write("Give a brief description of the trigger: ");
        _triggerDescription = Console.ReadLine();
        Console.Write("When did the trigger occur(MM/DD/HH/MM)? ");
        _triggerOccurance = Console.ReadLine();
    } 
    
    public string Serialize()
    {
        return $"{_triggerType}|{_triggerDescription}|{_triggerIntensity}|{_triggerOccurance}";
    }

    public void Deserialize(string[] trigger)
    {
        _triggerType = trigger[0];
        _triggerDescription = trigger[1];
        _triggerIntensity = trigger[2];
        _triggerOccurance = trigger[3];
    }

    public void DisplayTrigger()
    {
        Console.WriteLine();
        Console.WriteLine($"    >>Trigger<<\n    Type: {_triggerType}\n    Description: {_triggerDescription}\n    Intensity: {_triggerIntensity}\n    Occurance: {_triggerOccurance}");
    }
}