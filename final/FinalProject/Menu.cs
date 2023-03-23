using System;

public class Menu
{
    private string[] _mainMenu;
    private string[] _symptomMenu;
    private string[] _triggerMenu;
    private string[] _symptomSeverity;
    private string[] _listSymptoms;
    private int _userChoice;

    public Menu()
    {
        _mainMenu = new string[] {"Add Symptom", "Save File", "Load File", "List Symptoms", "Quit Program"};
        _symptomMenu = new string[] {"Muscular", "Respiratory"};
        _triggerMenu = new string[] {"Activity", "Environmental", "Food", "Medicine", "Other"};
        _symptomSeverity = new string[] {"Mild", "", "Moderate", "", "Severe"};
        _listSymptoms = new string[] {"System", "Trigger", "Date"};
    }


    public string[] GetMenu(string menu)
    {
        if (menu == "main")
            return _mainMenu;
        else if (menu == "symptom")
            return _symptomMenu;
        else if (menu == "trigger")
            return _triggerMenu;
        else
            return new string[] {"Oops, the argument for this menu was invalid."};
    }

    public void DisplayMenu(string[] menu) //Displays the menu
    {
        int number = 1;
        
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine();
        //loops through the menu array and displays each option with an incremental number.
        foreach (string item in menu)
        {
            Console.WriteLine($"  {number}) {item}");
            number++;
        }
        
        Console.WriteLine();
        Console.Write("Select a choice from the menu:  ");
        _userChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        //need error handling for wrong Type entered
    }

    public int GetUserChoice()
    {
        return _userChoice;
    }



}
