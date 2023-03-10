using System;

public class Menu
{
    private string[] _mainMenu;
    private string[] _createMenu;
    private string[] _listMenu;
    private int _number;
    private int _userChoice;

    public Menu()
    {
        _mainMenu = new string[] {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};
        _createMenu = new string[] {"Create simple goal", "Create eternal goal", "Create checkpoint goal"};
        _listMenu = new string[] {"List all goals","List simple goals","List eternal goals","List checkpoint goals"};
    }

     public void DisplayMenu(string[] array) //Displays the menu
    {
        _number = 1;
        
        //loops through _menuOptions and displays each option with a number.
        foreach (string item in array)
        {
            Console.WriteLine($"  {_number}) {item}");
            _number++;
        }
        Console.Write("Select a choice from the menu:  ");
        _userChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        //need error handling for wrong type entered

        // Console.Clear();
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

     public string[] GetListMenu()
    {
        return _listMenu;
    }


}