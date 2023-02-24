using System;
//This class displays the menu and gets the user's menu choice.
// This class holds the menu options and the user's choice. Methods are provided to display the menu and get the user's choice.
public class Menu
{
    private string[] _menuOptions;
    private int _userChoice;

    public Menu()
    {
        _menuOptions = new string[] {"Breathing" , "Reflection" , "Listing" , "Grounding", "Quit"};
    }

    
    public void DisplayMenu() //Displays the menu
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        int number = 1;
        //loops through _menuOptions and displays each option with a number.
        foreach (string item in _menuOptions)
        {
            Console.WriteLine($"  {number}) {item}");
            number++;
        }
        Console.Write("Select a choice from the menu:  ");
        _userChoice = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public int GetUserChoice() //Returns the user's choice
    {
        return _userChoice;
    }

     
   

}