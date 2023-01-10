using System;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;

        while (play == true)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,20);

            int tries = 0;

            // Console.Write("What is the magic number? ");

            // string magicNumberStr = Console.ReadLine();      It looks like I could combine these two lines into:
            // int magicNumber = int.Parse(magicNumberStr);     int magicNumber = int.Parse(Console.Readline())

            // Console.WriteLine($"The magic number is: {magicNumber}");
            
            Console.Write("What is your guess? ");              //In the example they assigned the guess variable to a negative number
                tries += 1;                                     // beore the while statement. this would eliminate the duplicate question
                string guessStr = Console.ReadLine();           // coding I did.
                int guess = int.Parse(guessStr);
                // Console.WriteLine($"Your guess is: {guess}");

            while (guess != number)
            {

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                    Console.WriteLine();
                    Console.Write("What is your guess? ");
                    tries += 1;
                    guessStr = Console.ReadLine();
                    guess = int.Parse(guessStr);
                    // Console.WriteLine($"Your guess is: {guess}");
                }
                
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                    Console.WriteLine();
                    Console.Write("What is your guess? ");
                    tries += 1;
                    guessStr = Console.ReadLine();
                    guess = int.Parse(guessStr);
                    // Console.WriteLine($"Your guess is: {guess}");
                }

                if (guess == number)
                {
                    Console.WriteLine("That is correct!");
                    Console.WriteLine($"You guessed it in {tries} tries!");
                }  
            }

            Console.Write("Do you want to play again? ");
            string playAgain = Console.ReadLine();
            if (playAgain == "No" || playAgain == "no")
                Console.Write("Thank you for playing!");
                play = false;
        }
    }

}