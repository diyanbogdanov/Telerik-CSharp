/*
Task 18.
Write a program for extracting all email addresses from given text.
All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/
using System;
using System.Text.RegularExpressions;
class ExtractEMails
{
    static void Main()
    {
        //Title
        Console.Title = "Extract E-Mails";

        //Input
        Console.Write("Enter e-mails");
        string emails = Console.ReadLine();

        //Processing and Output
        foreach (var item in Regex.Matches(emails, @"\w+@\w+.\w+"))
        {
            Console.WriteLine(item);
        }
    }
}