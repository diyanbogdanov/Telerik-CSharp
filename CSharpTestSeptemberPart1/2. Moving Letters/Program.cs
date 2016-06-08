using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string[] splitedInput = Console.ReadLine().Split();
        int max = 0;
        for (int i = 0; i < splitedInput.Length; i++)
        {
            if (splitedInput[i].Length > max)
            {
                max = splitedInput[i].Length;
            }
        }
        StringBuilder extractedWords = new StringBuilder();

        for (int i = 0; i < max + 1; i++)
        {
            for (int word = 0; word < splitedInput.Length; word++)
            {
                int currentWord = splitedInput[word].Length - 1 - i;
                if (currentWord >= 0)
                {
                    extractedWords.Append(splitedInput[word][currentWord]);
                }
            }
        }

        for (int position = 0; position < extractedWords.Length; position++)
        {
            char letter = extractedWords[position];
            int charPosition = (char.ToLower(letter) - 'a') + 1;
            extractedWords.Remove(position, 1);
            int newPosition = (position + charPosition) % (extractedWords.Length + 1);
            extractedWords.Insert(newPosition, letter);
        }
        Console.WriteLine(extractedWords);
    }
}

