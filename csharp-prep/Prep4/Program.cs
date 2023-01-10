using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            else 
            {
                numbers.Add(number);
            }
        }
        
        float count = numbers.Count;
        float sum = numbers.Sum();
        float avg = sum / numbers.Count;
        int largest = 0;
        int smallest = 99999999;
        
        foreach (int item in numbers)
        {
            if (item > largest)
            {
                largest = item;
            }

            if (item < smallest && item > 0)
            {
                smallest = item;
            }
        }



        Console.WriteLine($"The quantity of numbers in the list is: {count}");
        Console.WriteLine($"The sum of the numbers in the list is: {sum}");
        Console.WriteLine($"The average of the numbers in the list is: {avg}");
        Console.WriteLine($"The largest number in the list is: {largest}");
        Console.WriteLine($"The smallest positive number in the list is: {smallest}");
        
    }
}