/*
Task 06.
Write a program that enters the coefficients a, b and c of a quadratic equation 
a*x2 + b*x + c = 0 and calculates and prints its real roots.
Note that quadratic equations may have 0, 1 or 2 real roots.
*/
using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Title = "Quadratic Equation";
        Console.WriteLine("Please write a, b and c");
        Console.Write("a: ");
        int numberA = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int numberB = int.Parse(Console.ReadLine());
        Console.Write("c: ");
        int numberC = int.Parse(Console.ReadLine());
        if (numberA == 0)//checks number a 
        {
            Console.WriteLine("This is not an quadratic equation!");
        }
        else
        {
            double discriminant = (numberB * numberB) - 4 * (numberA * numberC);
            if (discriminant > 0)//checks discriminant
            {
                double x1 = (-numberB - Math.Sqrt(discriminant)) / (2 * numberA);
                double x2 = (-numberB + Math.Sqrt(discriminant)) / (2 * numberA);
                Console.WriteLine("The equation roots are: \nX1 = {0:F2} \nX2 = {1:F2}", x1, x2);//wrtite on console the two roots
            }
            else if (discriminant == 0)//checks discriminant
            {
                double x = -numberB / (2 * numberA);
                Console.WriteLine("There is only one root. \nX = {0}", x);//wrtite on console the one root
            }
            else if (discriminant < 0)//checks discriminant
            {
                Console.WriteLine("There is no solution!");//wrtite on console "There is no solution!"
            }
        }
    }
}
/*
In the topic "console input output" we solve this problem.
*/


