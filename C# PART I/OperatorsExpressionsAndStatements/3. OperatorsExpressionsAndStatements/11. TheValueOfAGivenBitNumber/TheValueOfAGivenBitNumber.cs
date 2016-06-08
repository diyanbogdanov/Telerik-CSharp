/*
Task 11.
Write an expression that extracts from a given integer i the value of a given bit number b. 
Example: i=5; b=2  value=1.
*/
using System;

class TheValueOfAGivenBitNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter number and bit position.");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine()); // Write number
        Console.Write("Bit posiotion: ");
        int bitPosition = int.Parse(Console.ReadLine()); // Write bit positon
        int mask = 1 << bitPosition; // Make mask
        int numberAndMask = number & mask; // I use & to see if the values match
        if (numberAndMask != 0) // if statement
        {
            Console.WriteLine("The value of a given number {0} at position {1} is 1.", number, bitPosition);
        }
        else
        {
            Console.WriteLine("The value of a given number {0} at positon {1} is 0.", number, bitPosition);
        }
        // Explains how the program works
        string numberBi = Convert.ToString(number, 2);
        string maskBi = Convert.ToString(mask, 2);
        string numberAndMaskBi = Convert.ToString(numberAndMask, 2);
        Console.WriteLine(" {0,8} : number \n {1,8} : mask \n {2,8} : number and mask", numberBi, maskBi, numberAndMaskBi);
    }
}

