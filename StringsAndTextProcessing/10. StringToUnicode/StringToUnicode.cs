/*
Task 10.
Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Sample input:
    Hi!
Expected output:
    \u0048\u0069\u0021
*/
using System;
using System.Text;

class StringToUnicode
{
    static void Main()
    {
        //Title
        Console.Title = "String To Unicode";

        //Input
        Console.Write("Input: ");
        string input = Console.ReadLine();

        //Processing
        StringBuilder unicodeChars = new StringBuilder(input.Length * 6);
        foreach (char unicodeNumber in input)
        {
            unicodeChars.AppendFormat(@"\u{0:X4}",(int)unicodeNumber);
        }

        //Output
        Console.WriteLine("Result: {0}",unicodeChars);
    }
}
