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
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        int number = 1;
        foreach (string item in _menuOptions)
        {
            Console.WriteLine($"  {number}) {item}");
            number++;
        }
        Console.Write("Select a choice from the menu:  ");
        _userChoice = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public int GetUserChoice()
    {
        return _userChoice;
    }

     
   

}