using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine();
        int choice = 0;
        GoalManager manage = new GoalManager();
        Menu menu = new Menu();
        while (choice != 6)
        {
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine();
            string[] main = menu.GetMainMenu();
            menu.DisplayMenu(main);
            choice = menu.GetUserChoice();

            if (choice == 1)//create Goal
            {
                Console.WriteLine("Which type of goal would you like to create? ");
                string[] create = menu.GetCreateMenu();
                menu.DisplayMenu(create);
                int createChoice = menu.GetUserChoice();
                if (createChoice == 1)//create simple goal
                {
                    SimpleGoal simple = new SimpleGoal();
                    simple.CreateGoal();
                    manage.AddGoal(simple);

                }

                else if (createChoice == 2)//create eternal goal
                {
                    EternalGoal eternal = new EternalGoal();
                    eternal.CreateGoal();
                    manage.AddGoal(eternal);
                }

                else if (createChoice == 3)//create checkpoint goal
                {
                    ChecklistGoal checkpoint = new ChecklistGoal();
                    checkpoint.CreateGoal();
                    manage.AddGoal(checkpoint);
                }

                else //selection out of range
                {
                    Console.Write("Oops");
                    Thread.Sleep(3000);
                }

            }

            else if (choice == 2)//List Goals
            {
                Console.WriteLine("Which type of goals would you like to view? ");
                string[] list = menu.GetListMenu();
                menu.DisplayMenu(list);
                int listChoice = menu.GetUserChoice();

                if (listChoice == 1)//List all goals
                {   
                    Console.WriteLine("All of your goals are:");
                    List<Goal> allGoals = manage.GetGoals();
                    foreach (Goal eachgoal in allGoals)
                    {
                        eachgoal.DisplayGoal();
                    }
                }
                
                else if (listChoice == 2)//List simple goals
                {
                    Console.Write("List Simple");
                    Thread.Sleep(3000); 
                }

                else if (listChoice == 3)//List eternal goals
                {
                    Console.Write("List Eternal");
                    Thread.Sleep(3000);
                }

                else if (listChoice == 4)//List checkpoint goals
                {
                    Console.Write("List Checkpoint");
                    Thread.Sleep(3000);
                }

                else//selection out of range
                {
                    Console.Write("Oops");
                    Thread.Sleep(3000);
                }
            }

            else if (choice == 3)//Save Goals
            {
                Console.Write("Please enter the file name where you would like to save your goals: ");
                string filename = Console.ReadLine();
                manage.SaveGoals(filename);
                
            }

            else if (choice == 4)//Load goals
            {
                Console.Write("Please enter the file name from where you would like to load your goals: ");
                string filename = Console.ReadLine();
                manage.LoadGoals(filename);
                
            }

            else if (choice == 5)//Record event
            {
                 
                
                
            }

            else if (choice == 6)//Quit
            {
                Console.Write("Quit");
                Thread.Sleep(3000);
            }

            else//selection out of range
            {
                Console.Write("Oops");
                Thread.Sleep(3000);
            }
        }
    }
}