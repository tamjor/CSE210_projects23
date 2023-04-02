using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Symptom Tracker.");
        Console.WriteLine("");
        Console.WriteLine("You can use this program to log symptoms with their potential/suspected triggers.\nYou will then be able to view your symptoms with their triggers to better gauge\nhow a trigger may be causing your symptoms.");
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

                    if (string.Equals(triggerChoice, "y", StringComparison.OrdinalIgnoreCase))
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
                manager.AddSymptomTriggerSet(set);
                
            }

           else if (userChoice == 2) //List Symptoms
            {
                Menu order = new Menu("order");
                Console.Write("How would you like to view your symptoms?");
                order.DisplayMenu();
                int orderChoice = order.GetUserChoice();
                
                if (orderChoice == 1)//By order added
                {
                    List<SymptomTriggerSet> sets = manager.GetSymptomTriggerList();
                    foreach (SymptomTriggerSet set in sets)
                    {   
                        set.DisplaySet();
                        Console.WriteLine();
                    }
                    Console.Write("Press ENTER to continue.");
                    Console.ReadLine();
                }
              
                else if (orderChoice == 2 )//By Symptom Type
                {
                    List<string> symptoms = new List<string>{"Muscular", "Respiratory"};
                    foreach (string item in symptoms)
                    {
                        List<SymptomTriggerSet> sets = manager.GetSymptomTriggerList();
                        foreach (SymptomTriggerSet set in sets)
                        {   
                            Symptom symptom = set.GetSymptom();
                            string symptomType = symptom.GetSymptomType();
                            if (symptomType == item)
                            {
                                set.DisplaySet();
                            }
                        }
                    }
                    Console.Write("Press ENTER to continue.");
                    Console.ReadLine();
                }

            }

            else if (userChoice == 3) //Change Symptom End Time
            {
                List<Symptom> noEnds = new List<Symptom>();
                List<SymptomTriggerSet> sets = manager.GetSymptomTriggerList();
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
                Console.WriteLine("These Symptoms do not have an End time listed: ");
                int number = 1;
                foreach (Symptom item in noEnds)
                {
                    string type = item.GetSymptomType();
                    Console.WriteLine($"  {number}) {type}");
                    number++;
                }
                Console.Write("To which Symptom would you like to add a End time? ");
                int endChoice = int.Parse(Console.ReadLine());
                noEnds[endChoice-1].SetSymptomEnd();
                
            }

            else if (userChoice == 4) //Save File
            {
                Console.Write("To which file do you want to save your information? ");
                string fileName = Console.ReadLine();
                manager.SavesymptomTriggerList(fileName);
                Console.WriteLine("Your information has been saved.");
                Thread.Sleep(500);
            } 

            else if (userChoice == 5) //Load File
            {
                Console.Write("From which file do you want to load your information? ");
                string fileName = Console.ReadLine();
                manager.LoadSymptomTriggerList(fileName);
                Console.WriteLine("Your information has been loaded.");
                Thread.Sleep(500);
            }

            else if (userChoice == 6) //Quit Program
            {
                Console.WriteLine("Thank you for using our program.\nHave a great day!");
                run = false;
                Thread.Sleep(300);
            }

            else
            {
                Console.WriteLine("That option is not available. Please try again.");
                Thread.Sleep(300);
            }
            
        }

    }
}