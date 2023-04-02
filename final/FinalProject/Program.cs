using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Symptom Tracker.");
        Console.WriteLine();
        Console.WriteLine("You can use this program to log symptoms with their potential/suspected triggers.\nYou will then be able to view your symptoms with their triggers to better gauge\nhow a trigger may be causing and/or effecting your symptoms.");
        Console.Write("Press ENTER to continue.");
        Console.ReadLine();

        bool run = true;
        SymptomManager manager = new SymptomManager();

        while (run == true)
        {
            Console.Clear();
            Menu main = new Menu("main");
            Console.WriteLine("Main Menu");
            main.DisplayMenu();
            int userChoice = main.GetUserChoice();

            if (userChoice == 1) //Add Symptom
            {
                SymptomTriggerSet set = new SymptomTriggerSet();
                Symptom symptom = new Symptom();

                symptom.LogSymptom();
                set.SetSymptom(symptom);

                bool newTrigger = true;

                while (newTrigger == true)
                {
                    Console.WriteLine();
                    Console.Write("Would you like to add a trigger for this symptom(Y/N)? ");
                    string triggerChoice = Console.ReadLine();
                    Console.Clear();

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
                Console.Clear();
                Console.Write("How would you like to view your symptoms?");

                Menu order = new Menu("order");
                order.DisplayMenu();
                int orderChoice = order.GetUserChoice();
                
                if (orderChoice == 1)//By order added
                {
                    Console.Clear();
                    List<SymptomTriggerSet> sets = manager.GetSymptomTriggerList();

                    foreach (SymptomTriggerSet set in sets)
                    {   
                        set.DisplaySet();
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.Write("Press ENTER to continue.");
                    Console.ReadLine();
                }
              
                else if (orderChoice == 2 )//By Symptom Type
                {
                    Console.Clear();
                    List<string> symptoms = new List<string>{"Cardiovascular", "Digestive", "Endocrine", "Dermal", "Immune", "Muscular", "Nervous", "Renal", "Reproductive", "Respiratory", "Skeletal"};
                    
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
                Console.Clear();
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
                Console.Clear();
                Console.Write("To which file do you want to save your information? ");
                string fileName = Console.ReadLine();

                manager.SavesymptomTriggerList(fileName);
                Console.WriteLine("Your information has been saved.");
                Thread.Sleep(700);
            } 

            else if (userChoice == 5) //Load File
            {
                Console.Clear();
                Console.WriteLine();
                Console.Write("From which file do you want to load your information? ");
                string fileName = Console.ReadLine();

                manager.LoadSymptomTriggerList(fileName);
                Console.WriteLine();
                Console.WriteLine("Your information has been loaded.");
                Thread.Sleep(700);
            }

            else if (userChoice == 6) //Quit Program
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Thank you for using our program.\nHave a great day!");
                run = false;
                Thread.Sleep(700);
            }

            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("That option is not available. Please try again.");
                Thread.Sleep(300);
            }
            
        }

    }
}