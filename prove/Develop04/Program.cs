using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Mindfulness Program!");
        int choice = 0;
        while (choice != 5)
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
            choice = menu.GetUserChoice();

            if (choice == 1) //Breathing Activity
            {   
                Breathing breathe = new Breathing();
                breathe.RunBreathing();
            }

            else if (choice == 2) //Reflection Activity
            {
                Reflection reflect = new Reflection();
                reflect.RunReflection();
            }

            else if (choice == 3) //Listing activity
            {
                Listing list = new Listing();
                list.RunListing();
            }

            else if (choice == 4) //Listing activity
            {
                Grounding ground = new Grounding();
                ground.RunGrounding();
            }

            else //Fat finger insurance
            {
                if (choice != 5)
                {
                    Console.WriteLine("That is not a recognized response.");
                    Console.WriteLine("Please try again.");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            
        }
        
        //Runs when the option to quit is chosen.
        Console.WriteLine("Thank you for participating. Have a wonderful day!");
        Thread.Sleep(3000);
        Console.Clear();

    }
}