/*
Task 13.
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
*/
using System;

class ExchangeBit
{
    static void Main()
    {
        Console.Title = "Exchange Bit";
        Console.WriteLine("Please enter a number to exchange bits 3, 4 and 5 wuth bits 24, 25 and 26: ");
        Console.Write("Number: ");
        uint number = uint.Parse(Console.ReadLine()); // Write your number
        uint mask = 1; // Mask value
        uint bit1; // Set the value
        uint bit2; // Set the value
        uint number1; // Set the value
        byte k = 3;  //Third bit
        byte p = 24; // Twenty-fourth bit
        Console.WriteLine("{0} : Original number : {1} in decimal", Convert.ToString(number, 2).PadLeft(32, '0'), number); // Convert.ToString(number, 2) <- conver the number from decimal to binary
        for (byte i = 1; i <= 3; i++, k++, p++)
        {
            mask = mask << k;
            bit1 = (mask & number) >> k;
            mask = mask >> k;
            mask = mask << p;
            bit2 = (mask & number) >> p;
            mask >>= p;
            if (bit1 != bit2)
            {
                if (bit1 == 1)
                {
                    number1 = number | (mask << p);
                    number = number1 ^ (mask << k);
                }
                else
                {
                    number1 = number ^ (mask << p);
                    number = number1 | (mask << k);
                }
            }
        }
        Console.WriteLine("{0} : Converted number : {1} in decimal", Convert.ToString(number, 2).PadLeft(32, '0'), number);
    }
}
