/*
Task 17.
Write a program that reads a date and time given in the format:
day.month.year hour:minute:second
and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/
using System;
class AddHoursAndMinutes
{
    static void Main()
    {
        //Title
        Console.Title = "Add Hours And Minutes";

        //Input
        Console.Write("Enter date: ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        //Processing
        DateTime newDate = date.AddMinutes(30.0).AddHours(6.0);

        //Output
        Console.WriteLine("Old date: {0}{1}New date: {2}", date, Environment.NewLine, newDate);
    }
}
