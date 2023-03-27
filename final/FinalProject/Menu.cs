using System;

public class Menu
{
    private string[] _mainMenu;
    // private string[] _systemMenu;
    // private string[] _triggerMenu;
    // private string[] _severityMenu;
    private string[] _listingMenu;
    private int _userChoice;

    public Menu()
    {
        _mainMenu = new string[] {"Add Symptom", "List Symptoms", "Add Symptom End Time", "Save File", "Load File", "Quit Program"};
        // _systemMenu = new string[] {"Muscular", "Respiratory"};
        // _triggerMenu = new string[] {"Activity", "Environmental", "Food", "Medicine"};
        // _severityMenu = new string[] {"Mild", "", "Moderate", "", "Severe"};
        _listingMenu = new string[] {"System", "Trigger", "Date"};
    }


    public string[] GetMenu(string menu)
    {
        if (menu == "main")
            return _mainMenu;
        // else if (menu == "system")
        //     return _systemMenu;
        // else if (menu == "trigger")
        //     return _triggerMenu;
        // else if (menu == "severity")
        //     return _severityMenu;
        else if (menu == "symptoms")
            return _listingMenu;
        else
            return new string[] {"Oops, the argument for this menu was invalid."};
    }

    public void DisplayMenu(string[] menu) //Displays the menu
    {
        int number = 1;
        
        Console.WriteLine();
        Console.WriteLine("Options:");
        Console.WriteLine();
        //loops through the menu array and displays each option with an incremental number.
        foreach (string item in menu)
        {
            Console.WriteLine($"  {number}) {item}");
            number++;
        }
        
        Console.WriteLine();
        Console.Write("Select an option from the menu:  ");
        _userChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        //need error handling for wrong Type entered
    }

    public int GetUserChoice()
    {
        return _userChoice;
    }



}
