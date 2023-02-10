using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Scripture Mastery Memorizing Program.");
        // Console.WriteLine("Which Scripture Mastery passages would you like to work on today?");
        // Console.WriteLine("Enter 'OT' for Old Testament.");
        // Console.WriteLine("Enter 'NT' for New Testament.");
        // Console.WriteLine("Enter 'BoM' for Book of Mormon.");
        // Console.WriteLine("Enter 'DC' for Doctrine and Covenants."); 
        // Console.Write(">>");
        Console.Write("Press <Enter> to begin.");
        Console.ReadLine();

        Reference reference = new Reference();
        reference.SetReference();
        string _reference = reference.GetReference();

        Scripture scripture = new Scripture(_reference);
        scripture.SetVerse();
        string _verse = scripture.GetVerse();

        Word word = new Word(_verse);

        bool quit = false;
        string input = "";
        do
        {
            Console.Clear();
            reference.DisplayReference();
            word.DisplayWords();
            Console.WriteLine();  
            Console.WriteLine();  
            Console.WriteLine("Press enter to hide words.");
            Console.WriteLine("Type 'Check' to restore the words.");
            Console.WriteLine("Type 'Hide' to hide the words again.");
            Console.WriteLine("Type 'Quit' to end the program.");
            Console.Write(">>");
            input = Console.ReadLine();

            if (input == "")
            {
                List<int> numbers = word.GetNumbers();
                if (numbers.Count() > 0)
                {
                    word.ChooseWords();
                    word.ReplaceWords();
                }
                else
                {
                    quit = true;
                }
            }

            else if (input.ToLower() == "Check")
            {
                word.RestoreWords();
            }

            else if (input.ToLower() == "Hide")
            {
                word.ReplaceWords();
            }

            else if (input.ToLower() == "Quit")
            {
                quit = true;
            }

            else 
            {
                Console.WriteLine();
                Console.WriteLine("That was not a recognized response.");
                Console.WriteLine("Please Try again.");
                Thread.Sleep(3000);
            }

        }
        while (quit == false);

        Console.WriteLine();


        




    }
}