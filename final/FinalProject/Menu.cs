using System;

public class Menu
{
    private string[] _menu;
    private int _userChoice;

    public Menu(string menu)
    {
        if (menu == "main")
            _menu = new string[] {"Add Symptom", "List Symptoms", "Add Symptom End Time", "Save File", "Load File", "Quit Program"};
        else if (menu == "sypmtom")
            _menu = new string[] {"Muscular", "Respiratory"};
        else if (menu == "trigger")
            _menu = new string[] {"Activity", "Environmental", "Food", "Medicine"};
        else if (menu == "order")
            _menu = new string[] {"By Symptom Type", "By Trigger Type", "By Symptom Start Date"};
    }


    public void DisplayMenu() //Displays the menu
    {
        int number = 1;
        
        Console.WriteLine();
        Console.WriteLine("Options:");
        Console.WriteLine();
        //loops through the menu array and displays each option with an incremental number.
        foreach (string item in _menu)
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
