/*
Task 09.
We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks. 
Example:
    Microsoft announced its next generation PHP compiler today.
    It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
Words: 
    "PHP, CLR, Microsoft"
The expected result:
    ********* announced its next generation *** compiler today.
    It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
*/
using System;
using System.Text;
class ReplaceTheWordWithAsterisks
{
    static void Main()
    {
        //Title
        Console.Title = "Replace The Word With Asterisks";

        //Input
        Console.Write("Input: ");
        string input = Console.ReadLine();
        Console.Write("Words: ");
        string words = Console.ReadLine();

        //Processing
        string output = ReplaceTheWords(input, words);

        //Output
        Console.WriteLine("The result is: {0}", output);
    }

    private static string ReplaceTheWords(string input, string words)
    {
        StringBuilder output = new StringBuilder();

        input = input.Remove(input.Length - 1);

        string[] wordsFromSentences = input.Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries);

        string[] splitWordsToReplaceWithAsterisks = words.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        for (int indexSentences = 0; indexSentences < wordsFromSentences.Length; indexSentences++)
        {
            string[] wordsInSentnce = wordsFromSentences[indexSentences].Split();
            for (int indexWord = 0; indexWord < wordsInSentnce.Length; indexWord++)
            {
                if (wordsInSentnce[indexWord] == splitWordsToReplaceWithAsterisks[0] ^
                    wordsInSentnce[indexWord] == splitWordsToReplaceWithAsterisks[1] ^
                    wordsInSentnce[indexWord] == splitWordsToReplaceWithAsterisks[2])
                {
                    if (indexWord == wordsInSentnce.Length - 1)
                    {
                        output.Append(new string('*', wordsInSentnce[indexWord].Length));
                    }
                    else
                    {
                        output.Append(new string('*', wordsInSentnce[indexWord].Length) + " ");
                    }
                }
                else
                {
                    if (wordsInSentnce[indexWord] == ".")
                    {
                        output.Append(wordsInSentnce[indexWord]);
                    }
                    else
                    {
                        if (indexWord == wordsInSentnce.Length - 1)
                        {
                            output.Append(wordsInSentnce[indexWord]);
                        }
                        else
                        {
                            output.Append(wordsInSentnce[indexWord] + " ");
                        }
                    }
                }
            }
            output.Append(". ");
        }

        return output.ToString();
    }
}
