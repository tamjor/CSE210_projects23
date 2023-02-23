using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Mindfulness Program!");
        int choice = 0;
        while (choice != 4)
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
            choice = menu.GetUserChoice();

            if (choice == 1) //Breathing Activity
            {   
                Breathing breathe = new Breathing();
                breathe.StartActivity();
                breathe.RunBreathing();
                breathe.EndActivity();
            }

            else if (choice == 2) //Reflection Activity
            {
                Reflection reflect = new Reflection();
                reflect.StartActivity();
                reflect.RunReflection();
                reflect.EndActivity();
            }

            else if (choice == 3)
            {
                Listing list = new Listing();
                list.StartActivity();
                list.RunListing();
                list.EndActivity();
            }

            else
            {
                if (choice != 4)
                {
                    Console.WriteLine("That is not a recognized response.");
                    Console.WriteLine("Please try again.");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            
        }
        

        Console.WriteLine("Thank you for participating. Have a wonderful day!");
        Thread.Sleep(3000);
        Console.Clear();

    }
}