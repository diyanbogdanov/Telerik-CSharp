/*
Task 02.
Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
*/
using System;

class DivideByFiveAndSeven
{
    static void Main()
    {
        Console.Title = "Divide By Five And Seven";
        Console.WriteLine("Please write a number..");
        int number = int.Parse(Console.ReadLine()); // Write a number
        if ((number % 5 == 0) && (number % 7 == 0)) // Check can the number to be divided by 5 and 7 at the same time and to has no residue
        {
            Console.WriteLine("The number CAN be divided by 5 and 7 at the same time!");
        }
        else
        {
            Console.WriteLine("The number CAN NOT be divided by 5 and 7 at the same time!");
        }
    }
}

