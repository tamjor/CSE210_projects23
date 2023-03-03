using System;

public class Menu
{
    private string[] _options;
    private string[] _subOptions;
    private int _number = 0;
    private int _userChoice;

    public Menu()
    {
        _options = new string[] {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};
        _subOptions = new string[] {"Create simple goal", "Create eternal goal", "Create checkpoint goal"};
    }

    public void DisplayMenu()
    {

    }
    public void DisplaySubMenu()
    {

    }

    public int GetUserChoice()
    {
        return _userChoice;
    }

}