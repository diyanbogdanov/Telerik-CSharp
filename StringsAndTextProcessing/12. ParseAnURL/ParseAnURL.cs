/*
Task 12.
Write a program that parses an URL address given in the format:
    [protocol]://[server]/[resource]
and extracts from it the [protocol], [server] and [resource] elements.
For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
    [protocol] = "http"
    [server] = "www.devbg.org"
    [resource] = "/forum/index.php"
*/
using System;
using System.Text;
using System.Text.RegularExpressions;
class ParseAnURL
{
    static void Main()
    {
        //Title
        Console.Title = "Parse An URL";

        //Input
        Console.Write("Enter an URL: ");
        string input = Console.ReadLine();

        //Processing
        string result = ProcessURL(input);

        //Output
        Console.WriteLine(result);
    }

    private static string ProcessURL(string input)
    {
        StringBuilder answer = new StringBuilder();

        var regexUrl = Regex.Match(input, "(.*)://(.*?)(/.*)").Groups;

        answer.Append("[protocol] = \"" + regexUrl[1] + "\"" + Environment.NewLine);
        answer.Append("[server] = \"" + regexUrl[2] + "\"" + Environment.NewLine);
        answer.Append("[protocol] = \"" + regexUrl[3] + "\"" + Environment.NewLine);

        return answer.ToString();
    }
}
