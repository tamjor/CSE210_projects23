// To exceed requirements I thought of another problem that may discourage people from writing in a journal:
// when they accidently don't save or save over previous journal entries. I addressed this issue by creating 
// class methods to validate the users commands to load, save, and quit. These methods check if the journal 
// has been saved, if it contains all the journal entries, and if the file they want to save to already exists
//  and gives them the option to abort the command or continue.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcoming comments and recommendations
        Console.WriteLine();
        Console.WriteLine("Thank you for choosing the Journal Program!");
        Console.WriteLine();
        Console.WriteLine("It is strongly recommended that you load a journal file before writing any entries.");
        Console.WriteLine("This will help prevent losing journal entries later.");
        Menu menu = new Menu();
        
        menu._run = true;
        
        do
        {
            menu.DisplayMenu();
            menu.GetUserInput();
            menu.MenuHandling();   
        }

        while(menu._run == true);
    }
}