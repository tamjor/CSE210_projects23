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
        Menu menu = new Menu();
        menu.DisplayMenu();
        int choice = menu.GetUserChoice();
        
        
        
        if (choice == 1)
        {   
            Breathing breathe = new Breathing();
            breathe.BeginActivity();
            int duration = breathe.GetActivityDuration();
            // Console.WriteLine($"Duration: {duration}");
            DateTime startTime = DateTime.Now;
            // Console.WriteLine($"Start Time: {startTime}");
            DateTime endTime = startTime.AddSeconds(duration);
            // Console.WriteLine($"End Time: {endTime}");
            
            DateTime currentTime = DateTime.Now;
            // Console.WriteLine($"Current Time before loop: {currentTime}");
            while (currentTime < endTime);
            {
                breathe.BreatheIn();
                breathe.BreatheOut();
                currentTime = DateTime.Now;
                // Console.WriteLine($"Current Time in loop: {currentTime}");
            }
            


        }

        else if (choice == 2)
        {
            Reflection reflect = new Reflection();
        }

        else if (choice == 3)
        {
            Listing list = new Listing();
        }

        else if (choice == 4)
        {
            Console.WriteLine("Thank you for participating. Have a wonderful day!");
            Thread.Sleep(3000);
            Console.Clear();
        }

        else
        {

        }
    }
}