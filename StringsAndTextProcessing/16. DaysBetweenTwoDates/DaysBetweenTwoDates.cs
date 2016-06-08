/*
Task 16.
Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:
    Enter the first date: 27.02.2006
    Enter the second date: 3.03.2004
    Distance: 4 days
*/
using System;
class DaysBetweenTwoDates
{
    static void Main()
    {
        //Title
        Console.Title = "Days Between Two Dates";

        //Input
        Console.Write("Enter start date: ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter end date: ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());        

        //Processing
        int days = endDate.Day - startDate.Day;

        //Output
        Console.WriteLine("Distance days: {0}",days);
    }
}
