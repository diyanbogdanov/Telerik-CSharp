/*
Task 11.
Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
*/
using System;
class ReadAndPrintNumber
{
    static void Main()
    {
        //Title
        Console.Title = "Read And Print Number";

        //Input
        Console.Write("Enter a number: ");
        long input = long.Parse(Console.ReadLine());

        //Processing
        string decimalNumber = Convert.ToDecimal(input).ToString();
        string hexadecimalNumber = input.ToString("X");
        string percentageNumber = input.ToString("P");
        string scientificnotationNumber = input.ToString("E");

        //Output
        Console.WriteLine("Result: ");
        Console.WriteLine("{0,15}",decimalNumber);//Decimal
        Console.WriteLine("{0,15}",hexadecimalNumber);//Hexadecimal
        Console.WriteLine("{0,15}",percentageNumber);//Percentage
        Console.WriteLine("{0,15}",scientificnotationNumber);//Scientific
    }
}