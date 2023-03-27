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
            string[] main = menu.GetMenu("main");
            menu.DisplayMenu(main);
            int userChoice = menu.GetUserChoice();

            if (userChoice == 1) //Add Symptom
            {
                Symptom symptom = new Symptom();
                SymptomTriggerSet set = new SymptomTriggerSet();

                symptom.LogSymptom();
                set.SetSymptom(symptom);

                bool newTrigger = true;
                while (newTrigger == true)
                {
                    Console.WriteLine("Would you like to add a trigger for this symptom(Y/N)? ");
                    string triggerChoice = Console.ReadLine();

                    if (triggerChoice == "Y")
                    {
                        Trigger trigger = new Trigger();
                        trigger.LogTrigger();
                        set.AddTriggerToList(trigger);
                    }
                    
                    else 
                    {
                        newTrigger = false;
                    }        
                }
                
           }

           else if (userChoice == 2) //List Symptoms
           {
            
           }

           else if (userChoice == 3) //Change Symptom End Time
           {
            
           }

           else if (userChoice == 4) //Save File
           {
            
           } 

           else if (userChoice == 5) //Load File
           {
            
           }

           else if (userChoice == 6) //Quit Program
           {
            
           }

           else
           {

           }
            
        }

    }
}