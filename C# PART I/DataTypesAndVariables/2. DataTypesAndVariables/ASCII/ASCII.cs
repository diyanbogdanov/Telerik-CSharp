/*
Find online more information about ASCII (American Standard Code for Information Interchange)
and write a program that prints the entire ASCII table of characters on the console.
*/
using System;

class ASCII
{
    static void Main()
    {
        for (int d = 1; d < 128; d++)
        {
            Console.WriteLine("Character: {0} = {1}",d ,(char)d); 
        }
    }
}

