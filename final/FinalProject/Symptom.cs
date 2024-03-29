using System;

public class Symptom
{
    private string _symptomType;
    private string _symptomLocation;
    private string _symptomDescription;
    private string _symptomSeverity;
    private string _symptomStart;
    private string _symptomEnd;


    public void LogSymptom()
    {
        Console.Clear();
        Menu menu = new Menu("symptom");

        Console.WriteLine();
        Console.Write("What type of symptom are you experiencing? ");

        menu.DisplayMenu();
        int typeChoice = menu.GetUserChoice();
        
        if (typeChoice == 1)
            _symptomType = "Cardiovascular";
        
        else if (typeChoice == 2)
            _symptomType = "Digestive";
        
        else if (typeChoice == 3)
            _symptomType = "Endocrine";
        
        else if (typeChoice == 4)
            _symptomType = "Dermal";
        
        else if (typeChoice == 5)
            _symptomType = "Immune";
       
        else if (typeChoice == 6)
            _symptomType = "Muscular";
        
        else if (typeChoice == 7)
            _symptomType = "Nervous";
        
        else if (typeChoice == 8)
            _symptomType = "Renal";
        
        else if (typeChoice == 9)
            _symptomType = "Reproductive";
        
        else if (typeChoice == 10)
            _symptomType = "Respiratory";
        
        else if (typeChoice == 11)
            _symptomType = "Skeletal";
        
        Console.Clear();
        Console.WriteLine();
        Console.Write($"Where is the {_symptomType} symptom located? ");
        _symptomLocation = Console.ReadLine();

        Console.WriteLine();
        Console.Write($"Give a brief description of the {_symptomType} symptom: ");
        _symptomDescription = Console.ReadLine();

        Console.WriteLine();
        Console.Write($"How severe is the {_symptomType} symptom on a scale of one to ten? ");
        _symptomSeverity = Console.ReadLine();

        Console.WriteLine();
        Console.Write($"When did the {_symptomType} symptom start?(MM/DD/HH/MM) ");
        _symptomStart = Console.ReadLine();

        Console.WriteLine();
        Console.Write($"Has the {_symptomType} symptom ended?(Y/N) ");
        string userChoice = Console.ReadLine();

        if (string.Equals(userChoice, "y", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine();
            Console.Write($"When did the {_symptomType} symptom end?(MM/DD/HH/MM) ");
            _symptomEnd = Console.ReadLine();
        }
    }

    public string GetSymptomEnd()
    {
        return _symptomEnd;
    }

    public void SetSymptomEnd()
    {
        Console.WriteLine();
        Console.Write($"When did the {_symptomType} symptom end?(MM/DD/HH/MM) ");
        _symptomEnd = Console.ReadLine();
    }

    public string Serialize()
    {
        if (_symptomEnd == null)
            return $"{_symptomType}|{_symptomLocation}|{_symptomDescription}|{_symptomSeverity}|{_symptomStart}";
        else 
            return $"{_symptomType}|{_symptomLocation}|{_symptomDescription}|{_symptomSeverity}|{_symptomStart}|{_symptomEnd}";    
    }

    public void Deserialize(string[] symptom)
    {
        if (symptom.Length == 5)
        {
            _symptomType = symptom[0];
            _symptomLocation = symptom[1];
            _symptomDescription = symptom[2];
            _symptomSeverity = symptom[3];
            _symptomStart = symptom[4];
        }
        
        else
        {
            _symptomType = symptom[0];
            _symptomLocation = symptom[1];
            _symptomDescription = symptom[2];
            _symptomSeverity = symptom[3];
            _symptomStart = symptom[4];
            _symptomEnd = symptom[5];
        }
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