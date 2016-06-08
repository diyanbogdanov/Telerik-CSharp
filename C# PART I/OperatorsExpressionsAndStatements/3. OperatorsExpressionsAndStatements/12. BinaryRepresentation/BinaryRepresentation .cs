/*
Task 12.
We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
Example: n = 5 (00000101), p=3, v=1  13 (00001101)
n = 5 (00000101), p=2, v=0  1 (00000001)
*/
using System;

class BinaryRepresentation
{
    static void Main()
    {
        Console.Title = "Binary Representation";
        Console.WriteLine("Please enter number, bit value(1 or 0) and position.");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine()); // Write your number
        Console.Write("Bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());// Write bit position
        Console.Write("Bit value(1 or 0): ");
        byte bitValue = byte.Parse(Console.ReadLine()); // Write bit value (1 or 0)
        int mask = 1 << bitPosition; // Make mask
        if (bitValue == 0)
        {
            int result = (~(mask) & number);
            Console.WriteLine("\nThe result is {0} equals {1}\n", Convert.ToString(result, 2), result); // Convert.ToString(result, 2) <- conver the result from decimal to binary
            // Explains how the program works
            string numberBi = Convert.ToString(number, 2).PadLeft(32, '0');
            string maskBi = Convert.ToString(~mask, 2).PadLeft(32, '0');
            string resultBi = Convert.ToString(result, 2).PadLeft(32, '0');
            Console.WriteLine("{0} : Original Number\n{1} : Inversed Mask\n{2} : Result", numberBi, maskBi, resultBi);
        }
        else
        {
            int result = (mask | number);
            Console.WriteLine("The result is {0} equals {1}\n", Convert.ToString(result, 2), result); // Convert.ToString(result, 2) <- conver the result from decimal to binary
            // Explains how the program works
            string numberBi = Convert.ToString(number, 2).PadLeft(32, '0');
            string maskBi = Convert.ToString(mask, 2).PadLeft(32, '0');
            string resultBi = Convert.ToString(result, 2).PadLeft(32, '0');
            Console.WriteLine("{0} : Original Number\n{1} : Mask\n{2} : Result", numberBi, maskBi, resultBi);
        }
    }
}

