using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string studentGrade = Console.ReadLine();
        int studentPercentage = int.Parse(studentGrade);
        string grade = "";
        string sign = "";

        if (studentPercentage >= 90)
        {
            grade = "A";
            
            if (studentPercentage <= 93)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        else if (studentPercentage >= 80 && studentPercentage < 90)
        {
            grade = "B";
            if (studentPercentage >= 87)
            {
                sign = "+";
            }
            else if (studentPercentage <= 83)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        else if (studentPercentage >= 70 && studentPercentage < 80)
        {
            grade = "C";
            if (studentPercentage >= 77)
            {
                sign = "+";
            }
            else if (studentPercentage <= 73)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        else if (studentPercentage >= 60 && studentPercentage < 70)
        {
            grade = "D";
            if (studentPercentage >= 67)
            {
                sign = "+";
            }
            else if (studentPercentage <= 63)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}{sign}.");

        if (studentPercentage >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the class!");
        } 

        if (studentPercentage < 70)
        {
            Console.WriteLine("Unfortunately, you have not passed the class. Don't give up! Try again.");
        } 

    }
}