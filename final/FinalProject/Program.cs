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
                BodySystem bodySystem;
                Trigger trigger;
                
                Console.WriteLine("Which bodily system is being affected? ");
                string[] systems = menu.GetMenu("system");
                menu.DisplayMenu(systems);
                int systemChoice = menu.GetUserChoice();

                if (systemChoice == 1)
                    bodySystem = new MuscularSystem();
                
                else if (systemChoice == 2)
                    bodySystem = new RespiratorySystem();
                
                else //selection out of range
                {
                    Console.Write("Oops, that option is not available. Please try again.");
                    Thread.Sleep(1000);
                    continue;
                }
                 
                //Do stuff with systems
                bodySystem.AddSystem();

                bool newTrigger = true;
                while (newTrigger == true)
                {
                    Console.WriteLine("What type of trigger would you like to add? ");
                    string[] triggers = menu.GetMenu("trigger");
                    menu.DisplayMenu(triggers);
                    int triggerChoice = menu.GetUserChoice();

                    if (triggerChoice == 1)
                        trigger = new ActivityTrigger();
                    
                    else if (triggerChoice == 2)
                        trigger = new EnvironmentalTrigger();
                    
                    else if (triggerChoice == 3)
                        trigger = new FoodTrigger();
                    
                    else if (triggerChoice == 4)
                        trigger = new MedicineTrigger();
                    else
                    {
                        newTrigger = false;
                    }
                }
                trigger.AddTrigger();
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