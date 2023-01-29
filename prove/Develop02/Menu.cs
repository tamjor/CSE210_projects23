// This class displays the menu, gets the user specified menu choice, and handles the appropriate actions.

using System;

public class Menu
{
    public bool _run = true;
    
    public int _userInput = 0;
    public Menu()
    {
    }

    Journal journal = new Journal();
    public void DisplayMenu()
    {    
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("----------------------------");
        Console.WriteLine("1 - Write a Journal Entry");
        Console.WriteLine("2 - Display Journal Entries");
        Console.WriteLine("3 - Load Journal");
        Console.WriteLine("4 - Save Journal");
        Console.WriteLine("5 - Quit Program");
    }

    // Gets the user specified menu option.
    public void GetUserInput()
    {   
        Console.WriteLine(); 
        Console.Write("Please enter the number of the option you wish to choose: ");
        _userInput = int.Parse(Console.ReadLine());
    }

    // Handles all menu actions
    public void MenuHandling()
    {
        if (_userInput == 1) //Write a journal entry
            {
                Entry entry = new Entry();
                entry.DisplayPrompt();
                entry.GetResponse();
                journal._journalEntries.Add(entry);
            }

        else if (_userInput == 2) //Display journal entries
        {
            journal.ShowEntries();
        }

        else if (_userInput == 3) //Load a file
        {
            journal.ValidateLoadFile(); 
        }

        else if (_userInput == 4) //Save the file
        {
            journal.ValidateSaveFile();
        }
        
        else if (_userInput == 5) //Quit the program
        {
            journal.CheckFile();
            
            if (journal._allGood == true)
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Journal Program.");
                Console.WriteLine("Goodbye.");
                Console.WriteLine();
                _run = false;
            }

            else if (journal._allGood == false)
            {
                string userInput = Console.ReadLine();

                if (userInput == "Y" || userInput == "y")
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using the Journal Program.");
                    Console.WriteLine("Goodbye.");
                    Console.WriteLine();
                    _run = false;
                }

                else
                {
                    _run = true;
                }    
            }
        }

        //Fat finger insurance
        else
        {
            Console.WriteLine();
            Console.WriteLine("That was not an allowed response.");
            Console.WriteLine("Please try again.");
        }
    }
}