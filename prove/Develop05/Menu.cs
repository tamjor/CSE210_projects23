using System;

public class Menu
{
    private string[] _mainMenu;
    private string[] _createMenu;
    private int _number;
    private int _userChoice;

    public Menu()
    {
        _mainMenu = new string[] {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};
        _createMenu = new string[] {"Create simple goal", "Create eternal goal", "Create checklist goal"};
    }

     public void DisplayMenu(string[] array) //Displays the menu
    {
        _number = 1;
        
        //loops through the menu array and displays each option with an incremental number.
        foreach (string item in array)
        {
            Console.WriteLine($"  {_number}) {item}");
            _number++;
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

    public string[] GetMainMenu()
    {
        return _mainMenu;
    }

     public string[] GetCreateMenu()
    {
        return _createMenu;
    }
}