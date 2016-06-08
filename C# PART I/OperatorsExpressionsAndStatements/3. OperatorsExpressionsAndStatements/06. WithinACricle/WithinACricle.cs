/*
Task 06.
Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
*/
using System;

class WithinACricle
{
    static void Main()
    {
        Console.Title = "Within A Cricle";
        Console.WriteLine("Please enter the cordinates X and Y .");
        Console.Write("X: ");
        double doubleX = double.Parse(Console.ReadLine()); // Write X
        Console.Write("Y: ");
        double doubleY = double.Parse(Console.ReadLine()); // Write Y
        Console.WriteLine("Now please enter the Radius.");
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine());  // Write radius
        if (((doubleY * doubleY) + (doubleX * doubleX)) <= (radius * radius)) // x*x + y*y <= radius*radius 
        {
            Console.WriteLine("The coordinates X:{0} and Y{1} are within the circle with radius {2}", doubleX, doubleY, radius);
        }
        else
        {
            Console.WriteLine("The coordinates X:{0} and Y{1} are NOT within the circle with radius {2}", doubleX, doubleY, radius);
        }
    }
}
