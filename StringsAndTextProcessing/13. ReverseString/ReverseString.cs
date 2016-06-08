/*
Task 13.
Write a program that reverses the words in given sentence.
Example: 
    "C# is not C++, not PHP and not Delphi!"
Result:
    "Delphi not and PHP, not C++ not is C#!".
*/
using System;
using System.Text;
using System.Text.RegularExpressions;
class ReverseString
{
    static void Main()
    {
        //Title
        Console.Title = "Reverse String";

        //Input
        Console.Write("Enter string to reverse: ");
        string input = Console.ReadLine();

        //Processing
        string reverseString = Reverse(input);

        //Output
        Console.WriteLine("Result:\r{0}", reverseString);
    }

    private static string Reverse(string input)
    {
        StringBuilder reveseString = new StringBuilder();

        string regex = @"\s+|,\s*|\.\s*|!\s*|$";

        string[] splitedInput = Regex.Split(input, regex);

        var separator = Regex.Matches(input, regex);

        for (int index = splitedInput.Length- 1; index >= 0; index--)
        {
            if (!String.IsNullOrEmpty(splitedInput[index]))
            {
                reveseString.Append(separator[index] + splitedInput[index]);
            }
            
        }

        return reveseString.ToString();
    }
}