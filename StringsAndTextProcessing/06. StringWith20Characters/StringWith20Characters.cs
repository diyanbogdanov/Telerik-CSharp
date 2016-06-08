/*
Task 06.
Write a program that reads from the console a string of maximum 20 characters.
If the length of the string is less than 20, the rest of the characters should be filled with '*'.
Print the result string into the console.
*/
using System;
class StringWith20Characters
{
    static void Main()
    {
        //Title
        Console.Title = "String With 20 Characters";

        //Input
        Console.Write("Input: ");
        string input = Console.ReadLine();

        //Processing
        string newString = "";
        if (input.Length > 20)
        {
            Console.WriteLine("You must enter string with less than 20 characters.");
        }
        else
        {
            if (input.Length < 20)
            {
                newString = input.PadRight(20,'*');
            }
        }

        //Output
        if (input.Length > 20)
        {
            Console.WriteLine("Good bye.");
        }
        else
        {
            if (input.Length == 20)
            {
                Console.WriteLine("Your string do not have any changes");
                Console.WriteLine("Good bye.");
            }
            else
            {
                Console.WriteLine("Your new string: {0}",newString);
                Console.WriteLine("Good bye.");
            }
        }
    }
}
