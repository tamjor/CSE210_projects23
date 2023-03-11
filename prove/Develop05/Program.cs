using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Eternal Quest Program! \nHere you'll be able to create and track your goals while scoring points!");
        Console.WriteLine();
        Console.WriteLine("Press ENTER to continue...");
        Console.ReadLine();

        int choice = 0;
        GoalManager manage = new GoalManager();
        Menu menu = new Menu();
        while (choice != 6)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"You have {manage.GetPoints()} points!");
            Console.WriteLine();
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine();
            string[] main = menu.GetMainMenu();
            menu.DisplayMenu(main);
            choice = menu.GetUserChoice();

            if (choice == 1)//create Goal
            {
                Console.Clear();
                Console.WriteLine("Which type of goal would you like to create? ");
                Console.WriteLine();
                string[] create = menu.GetCreateMenu();
                menu.DisplayMenu(create);
                int createChoice = menu.GetUserChoice();
                
                Goal goal;
                
                if (createChoice == 1)
                {
                    goal = new SimpleGoal(); //set goal to Simplegoal subclass
                }

                else if (createChoice == 2)
                {
                    goal = new EternalGoal(); //set goal to EternalGoal subclass
                }

                else if (createChoice == 3)
                {
                    goal = new ChecklistGoal(); //set goal to Checklistgoal subclass
                }

                else //selection out of range
                {
                    Console.Write("Oops, that option is not available. Please try again.");
                    Thread.Sleep(1000);
                    continue;
                }
                
                //create new goal based on subclass
                goal.CreateGoal();
                manage.AddGoal(goal);
                Console.WriteLine("Goal created");
                Thread.Sleep(500);
            }

            else if (choice == 2)//List Goals
            { 
                Console.Clear();
                Console.WriteLine("Your goals are:");
                Console.WriteLine();
                List<Goal> allGoals = manage.GetGoals();
                foreach (Goal eachgoal in allGoals)
                {
                    eachgoal.DisplayGoal();
                }
                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine(); 
            }

            else if (choice == 3)//Save Goals
            {
                Console.Write("Please enter the file name where you would like to save your goals: ");
                string filename = Console.ReadLine();
                manage.SaveGoals(filename);
                Console.WriteLine("File Saved");
                Thread.Sleep(500);
            }

            else if (choice == 4)//Load goals
            {
                Console.Write("Please enter the file name from where you would like to load your goals: ");
                string filename = Console.ReadLine();
                manage.LoadGoals(filename);
                Console.WriteLine("File Loaded");
                Thread.Sleep(500);  
            }

            else if (choice == 5)//Record event
            {
                Console.Clear();
                manage.RecordEvent();
                Console.WriteLine("Event Recorded");
                Thread.Sleep(500);
            }

            else if (choice == 6)//Quit
            {
                Console.Write("Thank your for using the Eternal Quest Program.");
                Thread.Sleep(3000);
            }

            else//selection out of range
            {
                Console.Write("Oops, that option is not available. Please try again.");
                Thread.Sleep(1000);
            }
        }
    }
}