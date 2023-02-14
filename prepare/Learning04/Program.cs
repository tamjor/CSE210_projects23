using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment simple = new Assignment("Tamara", "Fractions");
        Console.WriteLine(simple.GetSummary());
        MathAssignment math = new MathAssignment("Nicole", "Division", "7.2", "2-30, evens");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Assignment simple1 = new Assignment("Rose", "Programming");
        Console.WriteLine(simple1.GetSummary());
        WritingAssignment write = new WritingAssignment("Amber", "Creative Writing", "Silly Story");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());
    }
}