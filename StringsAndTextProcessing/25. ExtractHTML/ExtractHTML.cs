/*
Task 25.
Write a program that extracts from given HTML file its title (if available),
and its body text without the HTML tags. 
*/
using System;
using System.Text.RegularExpressions;

class ExtractHTML
{
    static void Main()
    {
        //Title
        Console.Title = "Extract HTML";

        //Input
        Console.Write("Enter HTML text: ");
        string htmlText = Console.ReadLine();

        //Processing and Output
        foreach (Match item in Regex.Matches(htmlText, "(?<=>).*?(?=<)"))
        {
            if (!String.IsNullOrWhiteSpace(item.Value))
            {
                Console.WriteLine(item);
            }
        }
    }
}
