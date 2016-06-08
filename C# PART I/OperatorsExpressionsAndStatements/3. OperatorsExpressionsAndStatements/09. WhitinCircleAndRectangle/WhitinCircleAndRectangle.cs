/*
Task 09.
Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/
using System;

class WhitinCircleAndRectangle
{
    static void Main()
    {
        Console.Title = "Whitin Circle And Rectangle";
        Console.WriteLine("Please enter the coordinates X & Y coordinates:");
        Console.Write("X: ");
        double coordinateX = double.Parse(Console.ReadLine()); // Write X
        double circleX = coordinateX - 1; // Circle X coordinate = X - 1 because ((1,1),3)
        Console.Write("Y: ");
        double coordinateY = double.Parse(Console.ReadLine()); // Write Y
        double circleY = coordinateY - 1; // Circle Y coordinate = Y - 1 because ((1,1),3)
        double circleRadius = 3;
        if ((circleX * circleX) + (circleY * circleY) <= (circleRadius * circleRadius)) // The formula
        {
            Console.WriteLine("The given coordinates are within a circle with radius: {0}", circleRadius);
        }
        else
        {
            Console.WriteLine("The given coordinates are NOT within a cirlce with radius: {0}", circleRadius);
        }
        // Rectangles coordinates
        double rectangleHeight = 2;
        double rectangleWidth = 6;
        double topY = 0 + (rectangleHeight / 2);
        double rightX = 0 + (rectangleWidth / 2);
        double bottomY = 0 - (rectangleHeight / 2);
        double leftX = 0 - (rectangleWidth / 2);
        double rectanglePointX = coordinateX - (-1); // = x + 1
        double rectanglePointY = coordinateY - 1;
        Console.WriteLine("Rectangle sides coordinates:\nTop Y: {0}\nRight X: {1}\nBottom Y: {2}\nLeft X: {3}", topY, rightX, bottomY, leftX);
        if ((rectanglePointY < topY) && (rectanglePointY > bottomY) && (rectanglePointX < rightX) && (rectanglePointX > leftX))
        {
            Console.WriteLine("The given points ARE within the rectangle.");
        }
        else
        {
            Console.WriteLine("The given points are NOT within the rectangle.");
        }
    }
}

