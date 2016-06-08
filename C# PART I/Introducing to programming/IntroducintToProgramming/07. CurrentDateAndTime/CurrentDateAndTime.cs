/*
Task 07.
Create a console application that prints the current date and time.
*/
using System;

class CurrentDateAndTime
{
    static void Main()
    {
        DateTime currentDateAndTime = DateTime.Now; //This will show you current DateTime in format day/month/year hours:minutes:seconds
        Console.WriteLine(currentDateAndTime);
    }
}