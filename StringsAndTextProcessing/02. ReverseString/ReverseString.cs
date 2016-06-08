/*
Task 02.
Write a program that reads a string, reverses it and prints the result at the console.
Example: "sample" > "elpmas".
*/
using System;
using System.Collections.Generic;
class ReverseString
{
    static void Main()
    {
        Console.Title = "Reverse String";//Title

        //input
        Console.Write("Write some thing: ");
        string input = Console.ReadLine();
        string reverseString = ReverseStringMethod(input);


        //output
        Console.WriteLine(reverseString);
    }

    private static string ReverseStringMethod(string input)
    {
        char[] inputCharArray = input.ToCharArray();
        string reverse = String.Empty;
        for (int index = inputCharArray.Length - 1; index > -1; index--)
        {
            reverse += inputCharArray[index];
        }
        return reverse;
    }
}

