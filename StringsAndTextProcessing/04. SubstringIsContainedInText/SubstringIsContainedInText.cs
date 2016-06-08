/*
Task 04.
Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
*/
using System;
using System.Text.RegularExpressions;
class SubstringIsContainedInText
{
    static void Main()
    {
        //Title
        Console.Title = "Substring Is Contained In Text";
    
        //Input
        Console.WriteLine("Write input: ");
        string input = Console.ReadLine();
        Console.Write("Write substring that you whant to find: ");
        string substring = Console.ReadLine();

        //Processing
        int result = Processing(input, substring);

        //Output
        Console.WriteLine("The result is {0}", result);
    }

    private static int Processing(string input, string substring)
    {
        int result = 0;

        string[] splitedInput = input.Split();
        
        string substringToLower = substring.ToLower();
        string substringToUpper = substring.ToUpper();
        string substringFirstLetterToUpper = char.ToUpper(substring[0]) + substring.Substring(1);

        foreach (string word in splitedInput)
        {
            result += Regex.Matches(word, substringToLower).Count;
            result += Regex.Matches(word, substringToUpper).Count;
            result += Regex.Matches(word, substringFirstLetterToUpper).Count;
        }

        return result;
    }
}