/*
Task 03.
Write an expression that calculates rectangle’s area by given width and height.
*/
using System;

class CalculatesRectangleArea
{
    static void Main()
    {
        Console.Title = "Calculates Rectangle Area";
        Console.WriteLine("Calculating rectangle area \nPlease enter height...");
        double heightNumber = double.Parse(Console.ReadLine()); //Here write your Height
        Console.WriteLine("Now please enter width...");
        double widthNumber = double.Parse(Console.ReadLine()); //Here write your Width
        double areaNumber = heightNumber * widthNumber; // This is the formula how to calculate the area 
        Console.WriteLine("The area of the rectangle is: {0}", areaNumber); //Here console print out the answer 
    }
}
