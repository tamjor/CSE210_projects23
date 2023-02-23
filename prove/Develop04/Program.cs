using System;

class Program
{
    static void Main(string[] args)
    {
        // Breathing breathe = new Breathing();
        // breathe.ReadyActivity();
        // // int duration = breathe.GetActivityDuration(); //for testing purposes
        // // Console.WriteLine($"You have entered {duration}"); //for testing purposes

        // breathe.BeginActivity(5);
        
        // for (bool done = false; done == false; done = breathe.GetDone())
        // {
        //     breathe.BreatheIn();
        //     breathe.BreatheOut();
        // }
        // breathe.EndActivity();
        int choice = 0;
        
        
        while (choice != 4)
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
            choice = menu.GetUserChoice();

            if (choice == 1) //Breathing Activity
            {   
                Breathing breathe = new Breathing();
                breathe.BeginActivity();
                int duration = breathe.GetActivityDuration();
                Console.WriteLine($"Duration: {duration}");
                breathe.SetEndTime(duration);
                DateTime endTime = breathe.GetEndTime(); 
                DateTime currentTime = DateTime.Now;
                Console.WriteLine($"Current Time before loop: {currentTime}");
                while (currentTime < endTime)
                {
                    breathe.BreatheIn();
                    breathe.BreatheOut();
                    currentTime = DateTime.Now;
                    Console.WriteLine($"Current Time in loop: {currentTime}");
                }
                breathe.EndActivity();
            }

            else if (choice == 2) //Reflection Activity
            {
                Reflection reflect = new Reflection();
                reflect.BeginActivity();





            }

            else if (choice == 3)
            {
                Listing list = new Listing();
            }

            else
            {

            }
        }

        Console.WriteLine("Thank you for participating. Have a wonderful day!");
        Thread.Sleep(3000);
        Console.Clear();

    }
}