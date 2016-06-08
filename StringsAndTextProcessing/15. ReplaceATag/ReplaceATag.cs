/*
Task 15.
Write a program that replaces in a HTML document given as string all the tags
<a href="…">…</a> with corresponding tags [URL=…]…/URL].
Sample HTML fragment:
    <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
    Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
Result:
    <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course.
    Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
*/
using System;
using System.Text.RegularExpressions;
class ReplaceATag
{
    static void Main()
    {
        //Title
        Console.Title = "Replace <A></A> Tag";

        //Input
        Console.Write("Enter HTML text: ");
        string input = Console.ReadLine();

        //Processing
        input = Processing(input);

        //output
        Console.WriteLine(input);
    }

    private static string Processing(string input)
    {
        string newHTML = Regex.Replace(input, "<a href=\"(.*?)\">(.*?)</a>", "[URL=$1]$2[/URL]");

        return newHTML;
    }
}
