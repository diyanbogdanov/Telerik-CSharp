/*
Task 07.
Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) 
operation over the first letter of the string with the first of the key, the second – with the second, etc.
When the last key character is reached, the next is the first.
*/
using System;
using System.Text;
class EncriptDecript
{
    static void Main()
    {
        //Title
        Console.Title = "Encript Decript";

        //Input
        Console.Write("Write input: ");
        string input = Console.ReadLine();
        Console.Write("Key: ");
        string key = Console.ReadLine();

        //Processing
        string encript = Encript(input, key);
        string decript = Decript(encript, key);

        //Output
        Console.WriteLine("Encript: {0}",encript);
        Console.WriteLine("Decript: {0}",decript);
    }

    private static string Decript(string input, string key)
    {
        return Encript(input, key);
    }

    private static string Encript(string input, string key)
    {
        StringBuilder result = new StringBuilder(input.Length);

        for (int index = 0; index < input.Length; index++)
        {
            result.Append((char)(input[index] ^ key[index % key.Length]));
        }

        return result.ToString();
    }
}
