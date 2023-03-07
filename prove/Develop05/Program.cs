using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        int choice = 0;
        while (choice != 6)
        {
            Menu menu = new Menu();
            string[] main = menu.GetMainMenu();
            string[] create = menu.GetCreateMenu();
            string[] list = menu.GetListMenu();
            menu.DisplayMenu(main);
            choice = menu.GetUserChoice();

            if (choice == 1)//create Goal
            {
                Console.Write("Create");
                Thread.Sleep(3000);
            }

            else if (choice == 2)//List Goals
            {
                Console.Write("List");
                Thread.Sleep(3000);
            }

            else if (choice == 3)//Save Goals
            {
                Console.Write("Save");
                Thread.Sleep(3000);
            }

            else if (choice == 4)//Load goals
            {
                Console.Write("Load");
                Thread.Sleep(3000);
            }

            else if (choice == 5)//Record event
            {
                Console.Write("Record");
                Thread.Sleep(3000);
            }

            else if (choice == 6)//Quit
            {
                Console.Write("Quit");
                Thread.Sleep(3000);
            }

            else
            {
                Console.Write("Oops");
                Thread.Sleep(3000);
            }
        }
    }
}