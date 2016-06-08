/*
Task 02.
Write a program that reads the radius r of a circle and prints its perimeter and area.
*/
using System;

class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        Console.Title = "Perimeter and area of a circle";//Title
        Console.WriteLine("Please write the radius \"r\" in centimeters ");
        Console.Write("r = ");
        double radius = double.Parse(Console.ReadLine()); //read the radius
        double circlePerimeter = (2 * (Math.PI * radius)); //calculate circle perimeter
        double circleArea = ((radius * radius) * Math.PI); // calculate circle area
        Console.WriteLine("The perimeter of circle is: {0:F2} centimeters", circlePerimeter);
        Console.WriteLine("The area of circle is: {0:F2} centimeters", circleArea);
    }
}

