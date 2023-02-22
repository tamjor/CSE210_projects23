using System;

public class Menu
{
    private string[] _menuOptions;
    private int _userChoice;

    public Menu()
    {
        _menuOptions = new string[] {"Breathing" , "Reflection" , "Listing" , "Quit"};
    }

    
    public void DisplayMenu()
    {
        Console.WriteLine("Choose which activity you would like to complete from the menu.");
        Console.WriteLine("Menu Options:");
        foreach (string item in _menuOptions)
        {
            Console.WriteLine($"    1. {item}");
        }
        Console.Write("Select a choice from the menu:  ");
        _userChoice = int.Parse(Console.ReadLine());
        Activity activity = new Activity();
        Console.Clear();
    }

    public int GetUserChoice()
    {
        return _userChoice;
    }

     
   

}