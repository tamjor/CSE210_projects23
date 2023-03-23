using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Symptom Tracker.");
        Console.WriteLine("");
        Console.WriteLine("Explain how program works");
        Console.WriteLine("");

        bool run = true;
        Menu menu = new Menu();

        while (run == true)
        {
           string[] menuType = menu.GetMenu("main");
           menu.DisplayMenu(menuType);
           int userChoice = menu.GetUserChoice();

           if (userChoice == 1) //Add Symptom
           {

           }

           else if (userChoice == 2) //Save File
           {
            
           }

           else if (userChoice == 3) //Load File
           {
            
           }

           else if (userChoice == 4) //List Symptoms
           {
            
           } 

           else if (userChoice == 5) //Quit Program
           {
            
           }
            
        }

    }
}