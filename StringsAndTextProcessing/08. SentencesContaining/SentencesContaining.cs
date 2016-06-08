/*
Task 08.
Write a program that extracts from a given text all sentences containing given word.
Example: The word is "in". The text is:
    We are living in a yellow submarine. We don't have anything else.
    Inside the submarine is very tight. So we are drinking all the day.
    We will move out of it in 5 days.
The expected result is:
    We are living in a yellow submarine.
    We will move out of it in 5 days.
Consider that the sentences are separated by "." and the words – by non-letter symbols.
*/
using System;
using System.Text;
class SentencesContaining
{
    static void Main()
    {
        //Title
        Console.Title = "Sentences Containing";

        //Input
        Console.Write("Input: ");
        string input = Console.ReadLine();
        Console.Write("Search word in sentences: ");
        string word = Console.ReadLine();

        //Processing
        string output = Processing(input, word);

        //Output
        Console.WriteLine("The result is:{0}",output);
    }
    private static string Processing(string input, string word)
    {
        StringBuilder output = new StringBuilder();

        string[] sentences = input.Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries);

        for (int indexSenteces = 0; indexSenteces < sentences.Length; indexSenteces++)
        {
            string[] splitSentenc = sentences[indexSenteces].Split();
            for (int indexWords = 0; indexWords < splitSentenc.Length; indexWords++)
            {
                if (splitSentenc[indexWords] == word)
                {
                    output.Append("\n" + sentences[indexSenteces] + ".");
                    break;
                }
            }
        }

        return output.ToString();
    }
}