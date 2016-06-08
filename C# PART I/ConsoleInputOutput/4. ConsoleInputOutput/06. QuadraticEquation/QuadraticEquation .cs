/*
Task 06.
Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
*/
using System;

class QuadraticEquation 
{
    static void Main()
    {
        Console.Title = "Quadratic equation";//Title
        Console.WriteLine("Please write a, b and c.");
        Console.Write("a: ");
        int numberA = int.Parse(Console.ReadLine());//read number a
        Console.Write("b: ");
        int numberB = int.Parse(Console.ReadLine());//read number b
        Console.Write("c: ");
        int numberC = int.Parse(Console.ReadLine());//read number c
        if (numberA == 0)//checks number a 
        {
            Console.WriteLine("This is not an quadratic equation!");
        }
        else
        {
            double discriminant = (numberB * numberB) - 4 * (numberA * numberC);
            if (discriminant > 0)//checks discriminant
            {
                double x1 = ((-numberB) - Math.Sqrt(discriminant)) / (2 * numberA);
                double x2 = ((-numberB) + Math.Sqrt(discriminant)) / (2 * numberA);
                Console.WriteLine("The equation roots are: \nX1 = {0:F2} \nX2 = {1:F2}",x1 ,x2);//wrtite on console the two roots
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
