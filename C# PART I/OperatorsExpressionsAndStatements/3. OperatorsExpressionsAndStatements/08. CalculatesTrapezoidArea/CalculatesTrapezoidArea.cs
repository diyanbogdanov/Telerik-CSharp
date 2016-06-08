/*
Task 08.
Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/
using System;

class CalculatesTrapezoidArea
{
    static void Main()
    {
        Console.Title = "Calculates Trapezoid Area";
        Console.WriteLine("Please enter side 'a' side 'b' and height 'h' .");
        Console.Write("a: ");
        double sideA = double.Parse(Console.ReadLine()); // Write A value
        Console.Write("b: ");
        double sideB = double.Parse(Console.ReadLine()); // Write B value
        Console.Write("h: ");
        double heightH = double.Parse(Console.ReadLine());// Write H value
        double trapezoidArea = (((sideA + sideB) / 2) * heightH); //The formula
        Console.WriteLine("The are of the trapezoid is: {0}", trapezoidArea);
    }
}

