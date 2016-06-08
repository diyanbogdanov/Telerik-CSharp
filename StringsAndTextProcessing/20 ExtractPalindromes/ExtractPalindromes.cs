/*
Task 20.
Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
*/
using System;
using System.Text;

class ExtractPalindromes
{
    static void Main()
    {
        //Title
        Console.Title = "Extract Palindromes";

        //Input
        Console.Write("Enter string with palindromes: ");
        string input = Console.ReadLine();

        //Processing
        string output = Extract(input);

        Console.WriteLine("Result: {0}",output);
    }

    private static string Extract(string input)
    {
        StringBuilder output = new StringBuilder();

        string[] words = input.Split(new string[] { " ", ",", "." }, StringSplitOptions.RemoveEmptyEntries);

        for (int index = 0; index < words.Length; index++)
        {
            if (IsPalindrome(words[index]) == true)
            {
                output.Append(words[index] + " ");
            }
        }

        return output.ToString();
    }

    private static bool IsPalindrome(string word)
    { 
            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
    }
}
