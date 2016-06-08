/*
Task 10.
Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. 
Example: v=5; p=1  false.
*/
using System;

class BitAtPosition
{
    static void Main()
    {
        Console.Title = "Bit At Position";
        Console.WriteLine("Please enter a number and position of the bit.");
        Console.Write("A number: ");
        int number = int.Parse(Console.ReadLine()); // Write a number
        Console.Write("The positon ot the bit: ");
        int bitPosition = int.Parse(Console.ReadLine()); // Write the position of the bit
        int mask = 1 << bitPosition; // Make mask
        int numberAndMask = number & mask; //I use & to see if the values match
        int bit = numberAndMask >> bitPosition; // move the value of initial position 
        if (numberAndMask != 0)
        {
            Console.WriteLine("At position {0} the given number {1} has a value 1", bitPosition, number);
        }
        else
        {
            Console.WriteLine("At position {0} the given number {1} has a value 0", bitPosition, number);
        }
        // Explains how the program works
        string numberBi = Convert.ToString(number, 2);
        string maskBi = Convert.ToString(mask, 2);
        string numberAndMaskBi = Convert.ToString(numberAndMask, 2);
        Console.WriteLine("{0,15} : number \n{1,15} : mask \n{2,15} : number and mask", numberBi, maskBi, numberAndMaskBi);
    }
}

