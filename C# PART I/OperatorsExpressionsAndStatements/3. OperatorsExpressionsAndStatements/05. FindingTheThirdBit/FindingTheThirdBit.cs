/*
Task 05.
Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
*/
using System;

class FindingTheThirdBit
{
    static void Main()
    {
        Console.Title = "Finding the bit 3.";
        Console.WriteLine("Please enter a number");
        int number = int.Parse(Console.ReadLine()); // Write number
        int moveByThree = 3;
        int mask = 1 << moveByThree; // Make mask
        int numberAndMask = number & mask;
        int bit = numberAndMask >> moveByThree; // Move the bit
        if (bit == 1) // Check the bit
        {
            Console.WriteLine("The bit 3 is 1.");
        }
        else
        {
            Console.WriteLine("The bit 3 is 0.");
        }
        /// Those lines of code helps to understand the bitwise operation
        string numberBi = Convert.ToString(number, 2);
        string maskBi = Convert.ToString(mask, 2);
        string numberAndMaskBi = Convert.ToString(numberAndMask, 2);
        Console.WriteLine(" {0,8} : number \n {1,8} : mask \n {2,8} : number and mask", numberBi, maskBi, numberAndMaskBi);
    }
}

