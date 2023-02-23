using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        do 
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
            choice = menu.GetUserChoice();

            if (choice == 1) //Breathing Activity
            {   
                Breathing breathe = new Breathing();
                breathe.StartActivity();
                DateTime endTime = breathe.GetEndTime();
                breathe.RunBreathing(endTime);
                breathe.EndActivity();
            }

            else if (choice == 2) //Reflection Activity
            {
                Reflection reflect = new Reflection();
                reflect.StartActivity();
                DateTime endTime = reflect.GetEndTime();
                reflect.RunReflection(endTime);
                reflect.EndActivity();
            }

            else if (choice == 3)
            {
                Listing list = new Listing();
                list.StartActivity();
                DateTime endTime = list.GetEndTime();
                list.RunListing(endTime);
                list.EndActivity();
            }
    
            else
            {
                Console.WriteLine("That is not a recognized response.");
                Console.WriteLine("Please try again.");
            }
            
        }
        while (choice != 4);

        Console.WriteLine("Thank you for participating. Have a wonderful day!");
        Thread.Sleep(3000);
        Console.Clear();

    }
}