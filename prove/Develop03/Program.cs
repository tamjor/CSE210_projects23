using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Scripture Mastery Memorizing Program.");
        Console.WriteLine("As we are studying The New Testament this year, a random \r\nscripture mastery from The New Testament will be used.");
        Console.WriteLine();
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
            Console.WriteLine("Type '+' to restore the words.");
            Console.WriteLine("Type '-' to hide the words again.");
            Console.WriteLine("Type 'x' to end the program.");
            Console.WriteLine();
            Console.WriteLine("Pressing 'Enter' after all words have been hidden will end the program.");
            Console.Write(">>");
            input = Console.ReadLine();

            if (input == "")
            {
                List<int> numbers = word.GetNumbers();
                if (numbers.Count() > 0)
                {
                    word.RandomNumbers();
                    word.ReplaceWords();
                }
                else
                {
                    quit = true;
                    Console.Clear();
                    Console.WriteLine("Thank you for using the Scripture Mastery Memorizing Program. \r\n \r\nHave a nice day!");
                }
            }

            else if (input == "+")
            {
                word.RestoreWords();
            }

            else if (input == "-")
            {
                word.ReplaceWords();
            }

            else if (input == "x")
            {
                Console.Clear();
                Console.WriteLine("\r\nThank you for using the Scripture Mastery Memorizing Program. \r\n \r\nHave a nice day!");
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