/*
Task 23.
Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example: 
    aaaaabbbbbcdddeeeedssaa
Result:
    abcdedsa
*/
using System;
using System.Text.RegularExpressions;

class RplacesAllConsecutiveLetters
{
    static void Main()
    {
        //Title
        Console.Title = "Rplaces All Consecutive Letters";

        //Input
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        //Processing
        string replacedLetters = Regex.Replace(input, @"(\w)\1+", "$1");

        //Output
        Console.WriteLine("Result: {0}",replacedLetters);
    }
}