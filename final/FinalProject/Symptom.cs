using System;

public class Symptom
{
    protected string _symptomType;
    protected string _symptomLocation;
    protected string _symptomDescription;
    protected string _symptomSeverity;
    protected string _symptomStart;
    protected string _symptomEnd;
    

   

    public void LogSymptom()
    {
        Console.Clear();
        Menu menu = new Menu("symptom");
        
        Console.Write("What type of symptom are you experiencing? ");
        menu.DisplayMenu();
        int typeChoice = menu.GetUserChoice();
        if (typeChoice == 1)
            _symptomType = "Muscular";
        else if (typeChoice == 2)
            _symptomType = "Respiratory";
        
        Console.Write("Where is the symptom located? ");
        _symptomLocation = Console.ReadLine();

        Console.Write("Give a brief description of the symptom: ");
        _symptomDescription = Console.ReadLine();

        Console.Write("How severe is the symptom on a scale of one to ten? ");
        _symptomSeverity = Console.ReadLine();

        Console.Write("When did the symptom start?(MM/DD/HH/MM) ");
        _symptomStart = Console.ReadLine();

        Console.Write("Has the symptom ended?(Y/N) ");
        string userChoice = Console.ReadLine();
        if (string.Equals(userChoice, "y", StringComparison.OrdinalIgnoreCase))
        {
            Console.Write("When did the symptom end?(MM/DD/HH/MM) ");
            _symptomEnd = Console.ReadLine();
        }
    }

    public string GetSymptomEnd()
    {
        return _symptomEnd;
    }

    public void SetSymptomEnd()
    {
        Console.Write("When did the symptom end?(MM/DD/HH/MM) ");
        _symptomEnd = Console.ReadLine();
    }

    public string Serialize()
    {
        return $"{_symptomType}|{_symptomLocation}|{_symptomDescription}|{_symptomSeverity}|{_symptomStart}|{_symptomEnd}";
    }

    public void Deserialize(string[] symptom)
    {
        _symptomType = symptom[0];
        _symptomLocation = symptom[1];
        _symptomDescription = symptom[2];
        _symptomSeverity = symptom[3];
        _symptomStart = symptom[4];
        _symptomEnd = symptom[5];
    }

    public void DisplaySymptom()
    {
        Console.WriteLine();
        Console.WriteLine ($">>Symptom<<\nType: {_symptomType}\nLocaction: {_symptomLocation}\nDescription: {_symptomDescription}\nSeverity: {_symptomSeverity}\nDuration: {_symptomStart} - {_symptomEnd}");
    }

    public string GetSymptomType()
    {
        return _symptomType;
    }
}