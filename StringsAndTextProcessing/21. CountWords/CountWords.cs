/*
Task 22.
Write a program that reads a string from the console and lists all different words in the string along
with information how many times each word is found.
*/
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        //Title
        Console.Title = "Count Words";

        //Input
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        //Processing
        var dictonary = new Dictionary<string, int>();
        foreach (Match word in Regex.Matches(input, @"\W+"))
        {
            dictonary[word.Value] = dictonary.ContainsKey(word.Value) ? dictonary[word.Value] + 1 : 1;
        }

        //Output
        foreach (var word in dictonary)
        {
            Console.WriteLine("{0}: {1}", word.Key, word.Value);
        }
    }
}
