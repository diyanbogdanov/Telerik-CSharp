using System;
using System.Text;
using System.Collections.Generic;

class magicWords
{
    static void Main()
    {
        int numberLines = int.Parse(Console.ReadLine());
        List<string> wordsFromInput = new List<string>();
        int countLetters = 0;
        StringBuilder finalString = new StringBuilder();
        for (int input = 0; input < numberLines; input++)
        {
            wordsFromInput.Add(Console.ReadLine());
            if (wordsFromInput[input].Length > countLetters)
            {
                countLetters = wordsFromInput[input].Length;
            }
        }
        int wordPosition = 0;
        for (int i = 0; i < wordsFromInput.Count; i++)
        {
            wordPosition = wordsFromInput[i].Length % (numberLines + 1);
            wordsFromInput.Insert(wordPosition, wordsFromInput[i]);
            if (wordPosition < i)
            {
                wordsFromInput.RemoveAt(i + 1);
            }
            else
            {
                wordsFromInput.RemoveAt(i);
            }

        }
        for (int i = 0; i < countLetters; i++)
        {
            for (int t = 0; t < wordsFromInput.Count; t++)
            {
                if (!(wordsFromInput[t].Length <= i))
                {
                    finalString.Append(wordsFromInput[t][i]);
                }
            }
        }
        Console.WriteLine(finalString);
    }
}

