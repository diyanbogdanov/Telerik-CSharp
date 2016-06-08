/*
Task 05.
You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.
The tags cannot be nested. 
*/
using System;
using System.Text;
class UpperCase
{
    static void Main()
    {
        //Title
        Console.Title = "Upper Case";

        //Input
        Console.Write("Input: ");
        string input = Console.ReadLine();

        //Procesing
        string output = ProcessingInput(input);

        //Output
        Console.WriteLine(output);
    }

    private static string ProcessingInput(string input)
    {
        StringBuilder result = new StringBuilder();

        int endOfOpenTag;
        int startOfCloseTag;
        int endOfCloseTag;

        for (int indexWord = 0; indexWord < input.Length; indexWord++)
        {
            if (input[indexWord] == '<')
            {
                endOfOpenTag = input.IndexOf('>', indexWord);
                startOfCloseTag = input.IndexOf('<', endOfOpenTag + 1);
                endOfCloseTag = input.IndexOf('>', startOfCloseTag);

                string toUpper = input.Substring(endOfOpenTag + 1, startOfCloseTag - endOfOpenTag - 1).ToUpper();

                result.Append(toUpper);

                indexWord = endOfCloseTag;
            }
            else
            {
                result.Append(input[indexWord]);
            }
        }

        return result.ToString();
    }
}
