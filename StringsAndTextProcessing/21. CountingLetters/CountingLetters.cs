/*
Task 21.
Write a program that reads a string from the console and prints all different
letters in the string along with information how many times each letter is found. 
*/
using System;

class CountingLetters
{
    static void Main()
    {
        //Title
        Console.Title = "Counting Letters";

        //Input
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        //Processing
        int[] lettersValues = new int['z' - 'a' + 1];
        foreach (char character in input.ToLower())
        {
            if ('a' <= character && character <= 'z')
            {
                lettersValues[character - 'a']++;
            }
        }

        //Outpus
        for (int index = 0; index < lettersValues.Length; index++)
        {
            if (lettersValues[index] != 0)
            {
                Console.WriteLine("{0}: {1}", (char)(index + 'a'), lettersValues[index]);
            }
        }
    }
}
