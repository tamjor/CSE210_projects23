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
        Console.Write("What type of symptom are you experiencing? ");
        _symptomType = Console.ReadLine();
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
        if (userChoice == "Y")
        {
            Console.Write("When did the symptom end?(MM/DD/HH/MM) ");
            _symptomEnd = Console.ReadLine();
        }
    }

    public void SetSymptomEnd(string symptomEnd)
    {
        Console.Write("When did the symptom end?(MM/DD/HH/MM) ");
        _symptomEnd = Console.ReadLine();
    }

}