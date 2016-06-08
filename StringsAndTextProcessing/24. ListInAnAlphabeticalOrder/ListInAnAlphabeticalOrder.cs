/*
Task 24.
Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ListInAnAlphabeticalOrder
{
    static void Main()
    {
        //Title
        Console.Title = "List In An Alphabetical Order";

        //Input
        Console.Write("Enter words separate with comas: ");
        string input = Console.ReadLine();

        //Processing
        List<string> words = new List<string>();

        foreach (Match word in Regex.Matches(input, @"\w+"))
        {
            words.Add(word.Value);
        }

        words.Sort();

        //Output
        Console.WriteLine("Result: ");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
