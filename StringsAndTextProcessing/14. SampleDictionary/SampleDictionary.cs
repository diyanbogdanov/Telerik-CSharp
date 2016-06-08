/*
Task 14.
A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:
    .NET – platform for applications from Microsoft
    CLR – managed execution environment for .NET
    namespace – hierarchical organization of classes
*/
using System;
using System.Text.RegularExpressions;
class SampleDictionary
{
    static void Main()
    {
        //Title
        Console.Title = "Sample Dictionary";

        //Input
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        //Processing
        string anwer = Processing(word);

        //Output
        Console.WriteLine(anwer);
    }

    private static string Processing(string word)
    {
        string answer = "unknown word";

        string[] dictionary = {".Net - platform for applications from Microsoft",
                               "CLR - managed execution environment for .NET",
                               "namespace - hierarchical organization of classes"};

        foreach (var item in dictionary)
        {
            var fragment = Regex.Match(item, "(.*?) - (.*)").Groups;

            if (fragment[1].Value == word)
            {
                answer = fragment[1] + " - " + fragment[2].Value;
                return answer;
            }
        }

        return answer;
    }
}