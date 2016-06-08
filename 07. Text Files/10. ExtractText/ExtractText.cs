﻿/*
Task 10.
Write a program that extracts from given XML file all the text without the tags.
*/
using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            for (int i; (i = input.Read()) != -1; )//Char by char
            {
                if (i == '>')
                {
                    string text = String.Empty;

                    while ((i = input.Read()) != -1 && i != '<') text += (char)i;
                    {

                        if (!String.IsNullOrWhiteSpace(text))
                       {
                            Console.WriteLine(text.Trim());
                        }
                    }
                }
            }
        }
    }
}