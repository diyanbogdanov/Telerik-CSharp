/*
Task 03. :
Write a program that safely compares floating-point numbers with precision of 0.000001. 
Examples:
(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true.
*/
using System;

class CompareFloatingPoint
{
    static void Main()
    {
        Console.WriteLine("Please enter your first number:");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your second number:");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        bool comparing = (Math.Abs(firstNumber - secondNumber) < 0.000001m);
        Console.WriteLine(comparing); 
    }
}

