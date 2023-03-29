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
        Menu main = new Menu("main");
        SymptomManager manager = new SymptomManager();

        while (run == true)
        {
            main.DisplayMenu();
            int userChoice = main.GetUserChoice();

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
                // Menu order = new Menu("order");
                // Console.Write("How would you like to view your symptoms?");
                // order.DisplayMenu();
                // int orderChoice = order.GetUserChoice();
                
                List<SymptomTriggerSet> sets = manager.GetSymptomTriggerSet();
                foreach (SymptomTriggerSet set in sets)
                {   
                    set.DisplaySet();
                }

                // if (orderChoice == 1)//By Symptom type
                // {
                    
                //     List<SymptomTriggerSet> sets = manager.GetSymptomTriggerSet();
                //     foreach (SymptomTriggerSet set in sets)
                //     {   
                //         Symptom symptom;
                //         List<Trigger> triggers;
                //         symptom = set.GetSymptom();
                //         triggers = set.GetTriggers();
                //     }


                // }

                // else if (orderChoice == 2 )//By Trigger Type
                // {

                // }

                // else if  (orderChoice == 3)//By Symptom Start Date
                // {

                // }
           }

           else if (userChoice == 3) //Change Symptom End Time
           {
                List<Symptom> noEnds = new List<Symptom>();
                List<SymptomTriggerSet> sets = manager.GetSymptomTriggerSet();
                foreach (SymptomTriggerSet set in sets)
                {   
                    Symptom symptom;
                    symptom = set.GetSymptom();
                    string symptomEnd = symptom.GetSymptomEnd();
                    if (symptomEnd == null)
                    {
                        noEnds.Add(symptom);
                    }
                }
                Console.WriteLine("To which Symptom would you like to add a End time? ");
                int number = 1;
                foreach (Symptom item in noEnds)
                {
                    Console.WriteLine($"  {number}) {item}");
                    number++;
                }
                Console.Write("To which Symptom would you like to add a End time? ");
                int endChoice = int.Parse(Console.ReadLine());
                noEnds[endChoice].SetSymptomEnd();
                
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